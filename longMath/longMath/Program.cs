using System;
using System.Collections.Generic;

namespace longMath
{
    class VeryLong
    {
        const int lbase = 9;
        public List<int> value { get; private set; }
        public VeryLong(string value)
        {
            value = value.Replace(".", "").Replace(",", "");
            this.value = new List<int>();
            bool minus = false;
            if (value[0] == '-')
            {
                value = value.Substring(1);
                minus = true;
            }
            if (value.Length % lbase != 0)
                this.value.Add(int.Parse(value.Substring(0, value.Length % lbase)));
            for (int i = value.Length / lbase - 1; i >= 0; i--)
            {
                this.value.Add(int.Parse(value.Substring(value.Length - lbase * (i + 1), lbase)));
            }
            if (minus)
                this.value[0] *= -1;

        }
        #region overloadings
        public VeryLong(List<int> value)
        {
            this.value = value;
        }
        public VeryLong(int value)
        {
            this.value = new List<int> { value };
        }
        public VeryLong(long value) : this(value.ToString()) { }
        public VeryLong(ulong value) : this(value.ToString()) { }
        public VeryLong(uint value) : this(value.ToString()) { }
        public VeryLong(short value) : this((int)value) { }
        public VeryLong(ushort value) : this((int)value) { }
        public VeryLong(byte value) : this((int)value) { }
        #region +overloading
        public static VeryLong operator +(VeryLong vl1, int vl2)
        {            
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        public static VeryLong operator +(VeryLong vl1, long vl2)
        {
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        public static VeryLong operator +(VeryLong vl1, ulong vl2)
        {
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        public static VeryLong operator +(VeryLong vl1, short vl2)
        {
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        public static VeryLong operator +(VeryLong vl1, ushort vl2)
        {
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        public static VeryLong operator +(VeryLong vl1, byte vl2)
        {
            return vl1 + new VeryLong(vl2);
        }
        public static VeryLong operator +(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) + vl2;
        }
        #endregion
        #region -overloading
        public static VeryLong operator -(VeryLong vl1, int vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        public static VeryLong operator -(VeryLong vl1, long vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        public static VeryLong operator -(VeryLong vl1, ulong vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        public static VeryLong operator -(VeryLong vl1, short vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        public static VeryLong operator -(VeryLong vl1, ushort vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        public static VeryLong operator -(VeryLong vl1, byte vl2)
        {
            return vl1 - new VeryLong(vl2);
        }
        public static VeryLong operator -(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) - vl2;
        }
        #endregion
        #region *overloading
        public static VeryLong operator *(VeryLong vl1, int vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        public static VeryLong operator *(VeryLong vl1, long vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        public static VeryLong operator *(VeryLong vl1, ulong vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        public static VeryLong operator *(VeryLong vl1, short vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        public static VeryLong operator *(VeryLong vl1, ushort vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        public static VeryLong operator *(VeryLong vl1, byte vl2)
        {
            return vl1 * new VeryLong(vl2);
        }
        public static VeryLong operator *(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) * vl2;
        }
        #endregion
        #region /overloading
        public static VeryLong operator /(VeryLong vl1, int vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        public static VeryLong operator /(VeryLong vl1, long vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        public static VeryLong operator /(VeryLong vl1, ulong vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        public static VeryLong operator /(VeryLong vl1, short vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        public static VeryLong operator /(VeryLong vl1, ushort vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        public static VeryLong operator /(VeryLong vl1, byte vl2)
        {
            return vl1 / new VeryLong(vl2);
        }
        public static VeryLong operator /(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) / vl2;
        }
        #endregion
        #region %overloading
        public static VeryLong operator %(VeryLong vl1, int vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        public static VeryLong operator %(VeryLong vl1, long vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        public static VeryLong operator %(VeryLong vl1, ulong vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        public static VeryLong operator %(VeryLong vl1, short vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        public static VeryLong operator %(VeryLong vl1, ushort vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        public static VeryLong operator %(VeryLong vl1, byte vl2)
        {
            return vl1 % new VeryLong(vl2);
        }
        public static VeryLong operator %(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) % vl2;
        }
        #endregion
        #region ==overloading
        public static bool operator ==(VeryLong vl1, int vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        public static bool operator ==(VeryLong vl1, long vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        public static bool operator ==(VeryLong vl1, ulong vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        public static bool operator ==(VeryLong vl1, short vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        public static bool operator ==(VeryLong vl1, ushort vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        public static bool operator ==(VeryLong vl1, byte vl2)
        {
            return vl1 == new VeryLong(vl2);
        }
        public static bool operator ==(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) == vl2;
        }
        #endregion
        #region !=overloading
        public static bool operator !=(VeryLong vl1, int vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        public static bool operator !=(VeryLong vl1, long vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        public static bool operator !=(VeryLong vl1, ulong vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        public static bool operator !=(VeryLong vl1, short vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        public static bool operator !=(VeryLong vl1, ushort vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        public static bool operator !=(VeryLong vl1, byte vl2)
        {
            return vl1 != new VeryLong(vl2);
        }
        public static bool operator !=(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) != vl2;
        }
        #endregion
        #region <overloading
        public static bool operator <(VeryLong vl1, int vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        public static bool operator <(VeryLong vl1, long vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        public static bool operator <(VeryLong vl1, ulong vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        public static bool operator <(VeryLong vl1, short vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        public static bool operator <(VeryLong vl1, ushort vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        public static bool operator <(VeryLong vl1, byte vl2)
        {
            return vl1 < new VeryLong(vl2);
        }
        public static bool operator <(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) < vl2;
        }
        #endregion
        #region >overloading
        public static bool operator >(VeryLong vl1, int vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        public static bool operator >(VeryLong vl1, long vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        public static bool operator >(VeryLong vl1, ulong vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        public static bool operator >(VeryLong vl1, short vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        public static bool operator >(VeryLong vl1, ushort vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        public static bool operator >(VeryLong vl1, byte vl2)
        {
            return vl1 > new VeryLong(vl2);
        }
        public static bool operator >(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) > vl2;
        }
        #endregion
        #region >=overloading
        public static bool operator >=(VeryLong vl1, int vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator >=(VeryLong vl1, long vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator >=(VeryLong vl1, ulong vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator >=(VeryLong vl1, short vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator >=(VeryLong vl1, ushort vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator >=(VeryLong vl1, byte vl2)
        {
            return vl1 >= new VeryLong(vl2);
        }
        public static bool operator >=(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        #endregion
        #region <=overloading
        public static bool operator <=(VeryLong vl1, int vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(int vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) <= vl2;
        }
        public static bool operator <=(VeryLong vl1, long vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(long vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) <= vl2;
        }
        public static bool operator <=(VeryLong vl1, ulong vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(ulong vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) >= vl2;
        }
        public static bool operator <=(VeryLong vl1, short vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(short vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) <= vl2;
        }
        public static bool operator <=(VeryLong vl1, ushort vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(ushort vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) <= vl2;
        }
        public static bool operator <=(VeryLong vl1, byte vl2)
        {
            return vl1 <= new VeryLong(vl2);
        }
        public static bool operator <=(byte vl1, VeryLong vl2)
        {
            return new VeryLong(vl1) <= vl2;
        }
        #endregion
        #endregion
        public static bool operator <(VeryLong vl1, VeryLong vl2)
        {
            return !(vl1 > vl2 || vl1 == vl2); // = !(vl1 > vl2) && !(vl1 == vl2)
        }
        public static bool operator >=(VeryLong vl1, VeryLong vl2)
        {
            return vl1 > vl2 || vl1 == vl2;
        }
        public static bool operator <=(VeryLong vl1, VeryLong vl2)
        {
            return !(vl1 > vl2);
        }        
        public static bool operator !=(VeryLong vl1, VeryLong vl2)
        {
            return !(vl1 == vl2);
        }
        public static bool operator ==(VeryLong vl1, VeryLong vl2)
        {
            return true;
        }
        public static bool operator >(VeryLong vl1, VeryLong vl2)
        {
            return true;
        }
        public static VeryLong operator -(VeryLong vl1)
        {
            vl1.value[0] = -vl1.value[0];
            return vl1;
        }
        public static VeryLong operator --(VeryLong vl1)
        {
            vl1.value[vl1.value.Count - 1]--;
            return vl1;
        }
        public static VeryLong operator ++(VeryLong vl1)
        {
            vl1.value[vl1.value.Count - 1]++;
            return vl1;
        }
        public static VeryLong operator +(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] < 0 ^ vl2.value[0] < 0)
                if (vl1.value[0] < 0)
                    return vl2 - -vl1;
                else
                    return vl1 - -vl2;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return -(-vl1 + -vl2);
            List<int> result;
            if (vl1.value.Count <= vl2.value.Count)
            {
                result = vl2.value;
                for (int i = vl1.value.Count - 1; i >= 0; i--)
                {
                    if (result[i] + vl1.value[i] < Math.Pow(10, lbase))
                        result[i] += vl1.value[i];
                    else
                    {
                        result[i] += vl1.value[i] - (int)Math.Pow(10, lbase);
                        if (i != 0)
                            result[i - 1]++;

                        else
                            result.Insert(0, 1);

                    }
                }

            }
            else
            {
                result = vl1.value;
                for (int i = vl2.value.Count - 1; i >= 0; i--)
                {
                    if (result[i] + vl2.value[i] < Math.Pow(10, lbase))
                        result[i] += vl2.value[i];
                    else
                    {
                        result[i] += vl2.value[i] - (int)Math.Pow(10, lbase);
                        if (i != 0)
                            result[i - 1]++;

                        else
                            result.Insert(0, 1);
                    }
                }
            }
            return new VeryLong(result);
        }
        public static VeryLong operator -(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] < 0 ^ vl2.value[0] < 0)
                if (vl1.value[0] < 0)
                    return vl2 + -vl1;
                else
                    return vl1 + -vl2;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return vl2 - -vl1;
            if (vl1.value.Count <= vl2.value.Count)
            {
                while (vl1.value.Count < vl2.value.Count)
                {
                    vl1.value.Insert(0, 0);
                }
            }
            else
            {
                while (vl2.value.Count < vl1.value.Count)
                {
                    vl2.value.Insert(0, 0);
                }
            }
            for (int i = vl1.value.Count - 1; i >= 0; i--)
            {
                if (vl1.value[i] - vl2.value[i] >= 0)
                    vl1.value[i] -= vl2.value[i];
                else
                {
                    if (i != 0)
                    {
                        if (vl1.value[i - 1] != 0)
                        {
                            vl1.value[i] -= vl2.value[i] + (int)Math.Pow(10, lbase);
                            vl1.value[i - 1]--;
                        }
                        else
                        {
                            vl1.value[i] -= vl2.value[i];
                        }
                    }
                    else
                    {
                        vl1.value[i] -= vl2.value[i];
                    }
                }
            }
            for (int i = 0; i < vl1.value.Count; i++)
            {
                if (vl1.value[i] == 0)
                    vl1.value.RemoveAt(0);
                else
                    break;

            }
            for (int i = 1; i < vl1.value.Count; i++)
            {
                if (vl1.value[i] < 0)
                    vl1.value[i] *= -1;
            }
            return vl1;
        }
        public static VeryLong operator *(VeryLong vl1, VeryLong vl2)
        {

            return vl1;
        }
        public static VeryLong operator /(VeryLong vl1, VeryLong vl2)
        {

            return vl1;
        }
        public static VeryLong operator %(VeryLong vl1, VeryLong vl2)
        {

            return vl1;
        }
        public static VeryLong Pow(VeryLong number, VeryLong pow)
        {
            if (pow == 0)
                return new VeryLong(1);
            else if (pow % 2 == 0)
                return Pow(number, pow / 2) * Pow(number, pow / 2);
            else
                return number * Pow(number, pow / 2) * Pow(number, pow / 2);
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < value.Count; i++)
            {
                string tmp = value[i].ToString();
                while (tmp.Length < lbase && i != 0)
                    tmp = "0" + tmp;
                result += tmp;
            }
            return result;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ","").Replace("(", "").Replace(")", "");
            #region ifs
            if (input.Contains("^"))
            {
                List<string> numbers = new List<string>(input.Split('^'));
                for (int i = numbers.Count - 1; i > 0; i--)
                {
                    //Pow(numbers[i-1], numbers[i]);
                }
            }
            else if (input.Contains("/") || input.Contains(":"))
            {
                List<string> numbers = new List<string>();
                if (input.Contains("/"))
                    numbers = new List<string>(input.Split('/'));
                else
                    numbers = new List<string>(input.Split(':'));
                for (int i = 0; i < numbers.Count; i++)
                {

                }
            }
            else if (input.Contains("*"))
            {
                List<string> numbers = new List<string>(input.Split('*'));
                for (int i = 0; i < numbers.Count; i++)
                {

                }
            }
            #endregion
            else if (input.Contains("-"))
            {
                string[] numbers = input.Split('-');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number -= new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }            
            else if (input.Contains("+"))
            {
                string[] numbers = input.Split('+');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number += new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }
            

        }

        /*static string Pow(string number, string pow)
        {
        if (pow == "0")
            return "1";
        else if (pow % 2 == 0)
            return Pow(number, pow / 2) * Pow(number, pow / 2);
        else
            return number * Pow(number, pow / 2) * Pow(number, pow / 2);
    }*/
    }
}
