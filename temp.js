M = 10;

function ToDigit(unit) {
  if (unit != "" && "0" <= unit && unit <= "9")
    return unit.charCodeAt(0) - "0".charCodeAt(0);
  else return 0;
}

function FromDigit(unit) {
  return String.fromCharCode("0".charCodeAt(0) + unit);
}

function TrimLongNumber(Number) {
  while (1 < Number.length && Number.charAt(0) == "0")
    Number = Number.substr(1, Number.length - 1);
  return Number;
}

function Compare(a, b) {
  var a = TrimLongNumber(a);
  var b = TrimLongNumber(b);
  var La = a.length;
  var Lb = b.length;
  if (La != Lb) return La > Lb ? 1 : -1;

  var i = 0;
  while (i < La && a.charAt(i) == b.charAt(i)) ++i;
  if (i == La) return 0;
  else return a.charAt(i) > b.charAt(i) ? 1 : -1;
}

function Div2(a) {
  var c = "";
  var cf = 0;
  var i = 0;
  var t = "";
  while (i < a.length) {
    t = ToDigit(a.substr(i, 1)) + cf * M;
    c = c + FromDigit(t >> 1);
    cf = t % 2;
    ++i;
  }
  return TrimLongNumber(c);
}

function Add(a, b) {
  var c = "";
  var cf = 0;
  var L = a.length < b.length ? b.length : a.length;
  var i = 0;
  while (i < L || cf != 0) {
    ai = ToDigit(a.charAt(a.length - i - 1));
    bi = ToDigit(b.charAt(b.length - i - 1));
    t = ai + bi + cf;
    if (M <= t) {
      c = FromDigit(t - M) + c;
      cf = 1;
    } else {
      c = FromDigit(t) + c;
      cf = 0;
    }
    ++i;
  }
  if (c == "") c = "0";
  return TrimLongNumber(c);
}

function Sub(a, b) {
  var c = "";
  var L = a.length < b.length ? b.length : a.length;
  var sign = false;
  if (Compare(a, b) == -1) {
    t = a;
    a = b;
    b = t;
    sign = true;
  }
  var i = 0;
  var cf = 0;
  while (i < L) {
    ai = ToDigit(a.charAt(a.length - i - 1));
    bi = ToDigit(b.charAt(b.length - i - 1));

    t = bi + cf;
    if (ai < t) {
      c = FromDigit(M + ai - t) + c;
      cf = 1;
    } else {
      c = FromDigit(ai - t) + c;
      cf = 0;
    }
    ++i;
  }
  if (c == "") c = "0";
  c = TrimLongNumber(c);
  if (sign) c = "-" + c;
  return c;
}

function Mul(a, b) {
  var c = "";
  var t = "";
  var p = "";
  if (Compare(a, b) == -1) {
    t = a;
    a = b;
    b = t;
  }
  while (Compare(b, "0") == 1) {
    if (ToDigit(b.substr(b.length - 1, 1)) % 2 == 0) {
      a = Add(a, a);
      b = Div2(b);
    } else {
      b = Sub(b, "1");
      p = Add(p, a);
    }
  }
  if (p == "") p = "0";
  return TrimLongNumber(p);
}

function Div(a, b) {
  var q = TrimLongNumber(a);
  b = TrimLongNumber(b);
  var La = q.length;
  var Lb = b.length;
  var p = "";
  var t = "";
  var i = 0;
  var m = 0;
  var r = 0;
  if (b == "0" || b == "") return "division by zero";
  while (Compare(b, q) != 1) {
    sh = "";
    r = 1;
    for (i = 0; i < La - Lb - 1; ++i) sh += "0";
    t = q.substr(0, Lb + 1);
    if (Compare(t, b + "0") != -1) {
      t = q.substr(0, Lb);
      sh += "0";
      r = 0;
    }
    d = "9";
    m = Mul(b, d) + sh;
    while (Compare(q, m) == -1) {
      d = Sub(d, "1");
      m = Mul(b, d) + sh;
    }
    q = Sub(q, m);
    L = La;
    La = q.length;
    p = p + d;
    if (Compare(q, b) == -1) p += sh;
    else {
      for (i = 1; i < L - La - r; ++i) p += "0";
    }
  }
  if (p == "") p = "0";
  return p;
}

function AddLong() {
  a = document.getElementById("add.a").value;
  b = document.getElementById("add.b").value;
  document.getElementById("add.c").value = Add(a, b);
}

function SubLong() {
  a = document.getElementById("sub.a").value;
  b = document.getElementById("sub.b").value;
  document.getElementById("sub.c").value = Sub(a, b);
}

function Div2Long() {
  a = document.getElementById("div2.a").value;
  document.getElementById("div2.c").value = Div2(a);
}

function MulLong() {
  a = document.getElementById("mul.a").value;
  b = document.getElementById("mul.b").value;
  document.getElementById("mul.c").value = Mul(a, b);
}

function DivLong() {
  a = document.getElementById("div.a").value;
  b = document.getElementById("div.b").value;
  document.getElementById("div.c").value = Div(a, b);
}
