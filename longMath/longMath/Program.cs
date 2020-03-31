using System;
using System.Collections;
using System.Collections.Generic;

namespace longMath
{
    class VeryLong
    {
        const int lbase = 9;
        static int cbase = (int)Math.Pow(10, lbase);
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
        public VeryLong() : this(0) { }
        public VeryLong(VeryLong value) : this(new List<int>(value.value)) { }
        public VeryLong(int[] value) : this(new List<int>(value)) { }
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
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;
            else
            {
                VeryLong vl2 = (VeryLong)obj;
                return vl2.ToString() == ToString();
            }
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator <(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] >= 0 && vl2.value[0] < 0)
                return false;
            else if (vl1.value[0] < 0 && vl2.value[0] >= 0)
                return true;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return !(-vl1 < -vl2);
            else if (vl1.value.Count < vl2.value.Count)
                return true;
            else if (vl1.value.Count > vl2.value.Count)
                return false;
            else
            {
                bool result = false;
                if (vl1.value.Count <= vl2.value.Count)
                {
                    for (int i = 0; i < vl1.value.Count; i++)
                    {
                        if (vl1.value[i] < vl2.value[i])
                        {
                            result = true;
                            break;
                        }
                        else if (vl1.value[i] > vl2.value[i])
                            break;
                    }
                }
                else
                {
                    for (int i = 0; i < vl2.value.Count; i++)
                    {
                        if (vl1.value[i] < vl2.value[i])
                        {
                            result = true;
                            break;
                        }
                        else if (vl1.value[i] > vl2.value[i])
                            break;
                    }
                }
                return result;
            }
        }
        public static bool operator >=(VeryLong vl1, VeryLong vl2)
        {
            return !(vl1 < vl2);
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
            if (vl1.value.Count != vl2.value.Count)
                return false;
            else
            {
                bool result = true;
                for (int i = 0; i < vl1.value.Count; i++)
                {
                    if (vl1.value[i] != vl2.value[i])
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }

        }
        public static bool operator >(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] < 0 && vl2.value[0] >= 0)
                return false;
            else if (vl1.value[0] >= 0 && vl2.value[0] < 0)
                return true;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return !(-vl1 > -vl2);
            else if (vl1.value.Count > vl2.value.Count)
                return true;
            else if (vl1.value.Count < vl2.value.Count)
                return false;
            else
            {
                bool result = false;
                if (vl1.value.Count <= vl2.value.Count)
                {
                    for (int i = 0; i < vl1.value.Count; i++)
                    {
                        if (vl1.value[i] > vl2.value[i])
                        {
                            result = true;
                            break;
                        }
                        else if (vl1.value[i] < vl2.value[i])
                            break;
                    }
                }
                else
                {
                    for (int i = 0; i < vl2.value.Count; i++)
                    {
                        if (vl1.value[i] > vl2.value[i])
                        {
                            result = true;
                            break;
                        }
                        else if (vl1.value[i] < vl2.value[i])
                            break;
                    }
                }
                return result;
            }
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
            if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return vl2 - -vl1;
                else
                    return vl1 - -vl2;
            else if (vl1 < 0 && vl2 < 0)
                return -(-vl1 + -vl2);
            if (vl1.value.Count <= vl2.value.Count)
            {
                
                for (int i = vl1.value.Count - 1; i >= 0; i--)
                {
                    if (vl2.value[vl2.value.Count - vl1.value.Count + i] + vl1.value[i] < Math.Pow(10, lbase))
                        vl2.value[vl2.value.Count - vl1.value.Count + i] += vl1.value[i];
                    else
                    {
                        vl2.value[vl2.value.Count - vl1.value.Count + i] += vl1.value[i] - cbase;
                        if (vl2.value.Count - vl1.value.Count + i != 0)
                            vl2.value[vl2.value.Count - vl1.value.Count + i - 1]++;

                        else
                            vl2.value.Insert(0, 1);

                    }
                }
                return vl2;

            }
            else
            {
                for (int i = vl2.value.Count - 1; i >= 0; i--)
                {
                    if (vl1.value[vl1.value.Count - vl2.value.Count + i] + vl2.value[i] < Math.Pow(10, lbase))
                        vl1.value[vl1.value.Count - vl2.value.Count + i] += vl2.value[i];
                    else
                    {
                        vl1.value[vl1.value.Count - vl2.value.Count + i] += vl2.value[i] - cbase;
                        if (vl1.value.Count - vl2.value.Count + i != 0)
                            vl1.value[vl1.value.Count - vl2.value.Count + i - 1]++;

                        else
                            vl1.value.Insert(0, 1);

                    }
                }
                return vl1;
            }            
        }
        public static VeryLong operator -(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return vl2 + -vl1;
                else
                    return vl1 + -vl2;
            else if (vl1 < 0 && vl2 < 0)
                return vl2 - -vl1;
            else if(vl1 <= vl2)
                return -(vl2 - vl1);
            while (vl2.value.Count < vl1.value.Count)
            {
                vl2.value.Insert(0, 0);
            }
            VeryLong result = new VeryLong(vl1);
            for (int i = result.value.Count - 1; i >= 0; i--)
            {
                if (result.value[i] - vl2.value[i] >= 0)
                    result.value[i] -= vl2.value[i];
                else
                {
                    if (i != 0)
                    {
                        result.value[i] -= vl2.value[i] - cbase;
                        result.value[i - 1]--;
                    }
                    else
                    {
                        result.value[i] -= vl2.value[i];
                        if (result.value.Count < vl2.value.Count && result.value[i] < 0)
                            result.value[i] *= -1;
                    }
                }
                if (result.value.Count < vl2.value.Count)
                {
                    result.value.Insert(0, 0);
                    i++;
                }

            }
            for (int i = 0; i < result.value.Count; i++)
            {
                if (result.value[i] == 0 && i != result.value.Count - 1)
                {
                    result.value.RemoveAt(0);
                    i--;
                }
                else
                    break;
            }
            for (int i = 0; i < vl2.value.Count; i++)
            {
                if (vl2.value[i] == 0 && i != vl2.value.Count - 1)
                {
                    vl2.value.RemoveAt(0);
                    i--;
                }
                else
                    break;
            }
            for (int i = 0; i < result.value.Count; i++)
            {
                if (result.value[i] < 0)
                {

                }
            }
            return result;
        }
        public static VeryLong operator *(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return -(vl2 * -vl1);
                else
                    return -(vl1 * -vl2);
            else if (vl1 < 0 && vl2 < 0)
                return -vl2 * -vl1;
            else if (vl1 == 0 || vl2 == 0)
                return new VeryLong();
            else if (vl1 == 1)
                return vl2;
            else if (vl2 == 1)
                return vl1;
            return Multiplication(vl1, vl2);
        }
        static VeryLong Multiplication(VeryLong vl1, VeryLong vl2)
        {

            if (vl1.value.Count == 1 && vl2.value.Count == 1)
            {
                return new VeryLong((ulong)vl1.value[0] * (ulong)vl2.value[0]);
            }
            else
            {
                VeryLong result = new VeryLong();
                if (vl1.value.Count <= vl2.value.Count)
                    for (int i = vl1.value.Count - 1; i >= 0; i--)
                    {
                        for (int j = vl2.value.Count - 1; j >= 0; j--)
                        {
                            if (i == 2)
                            {

                            }
                            VeryLong temp = new VeryLong((ulong)vl1.value[i] * (ulong)vl2.value[j]);
                            temp.value.InsertRange(temp.value.Count,new int[vl2.value.Count+ vl1.value.Count - j - i - 2]);
                            result += temp;
                        }
                    }
                else
                    for (int i = vl2.value.Count - 1; i >= 0; i--)
                    {
                        for (int j = vl1.value.Count - 1; j >= 0; j--)
                        {
                            VeryLong temp = new VeryLong((ulong)vl2.value[i] * (ulong)vl1.value[j]);
                            temp.value.InsertRange(temp.value.Count, new int[vl1.value.Count + vl2.value.Count - j - i - 2]);
                            result += temp;
                        }
                    }
                if (result.value[0] == 0)
                    result.value.RemoveAt(0);
                return result;
            }
        }
        public static VeryLong operator /(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 == 0)
                return new VeryLong(0);
            else if (vl2 == 0)
                throw new DivideByZeroException();
            else if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return -(-vl1 / vl2);
                else
                    return -(vl1 / -vl2);
            else if (vl1 < 0 && vl2 < 0)
                return -vl1 / -vl2;
            else if (vl2 == 2)
            {
                VeryLong result = vl1 * 5;
                int temp = 0;
                for (int i = 0; i < result.value.Count; i++)
                {
                    if (i == 0 && result.value[i] / 10 == 0)
                    {
                        temp = result.value[i] % 10;
                        result.value.RemoveAt(0);
                        if (i < result.value.Count)
                        {
                            int temp1 = result.value[i] % 10;
                            result.value[i] /= 10;
                            result.value[i] += temp * (cbase / 10);
                            temp = temp1;
                        }
                    }
                    else
                    {
                        int temp1 = result.value[i] % 10;
                        result.value[i] /= 10;
                        result.value[i] += temp * cbase;
                        temp = temp1;
                    }                    
                }
                return result;
            }
            VeryLong up = new VeryLong(new int[vl1.value.Count - vl2.value.Count + 1]);
            up.value[0] = 1;
            VeryLong down = new VeryLong();            
            while (up - down != 1)
            {
                if (vl2 * ((up + down) / 2) < vl1)
                    down += (up - down) / 2;
                else if (vl2 * ((up + down) / 2) > vl1)
                    up -= (up - down) / 2;
                else
                    return vl2 * ((up - down) / 2);
            }
            return vl2 * down;
        }
        public static VeryLong operator %(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 == 0)
                return new VeryLong(0);
            else if (vl2 == 0)
                throw new DivideByZeroException();
            else if (vl2 == 2)
                return new VeryLong(vl1.value[vl1.value.Count - 1] % 2);
            vl1 = Mod(vl1);
            vl2 = Mod(vl2);
            return vl1 - vl1 / vl2 * vl2;
        }
        public static VeryLong Mod(VeryLong vl1)
        {
            if (vl1 < 0)
                return -vl1;
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
            string input = "4511263156549903003502425944020621017624018923015950620210037836734253630/456765434567654345676543567890234567".Replace(" ", "").Replace("(", "").Replace(")", "");
            #region ifs
            if (input.Contains("^"))
            {
                string[] numbers = input.Split('^');
                if (numbers.Length <= 1)
                {
                   Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number = VeryLong.Pow(number, new VeryLong(numbers[i]));
                }

            }
            else if (input.Contains("/") || input.Contains(":"))
            {
                string[] numbers;
                if (input.Contains("/"))
                    numbers = input.Split('/');
                else
                    numbers = input.Split(':');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number /= new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }
            else if (input.Contains("*"))
            {
                string[] numbers = input.Split('*');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number *= new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }
            #endregion
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
            else if (input.Contains("-"))
            {
                List<string> numbers = new List<string>(input.Replace("--", "ё").Split("-".ToCharArray()));
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i].Contains("ё"))
                    {
                        numbers.InsertRange(i, numbers[i].Split('ё'));
                        numbers.RemoveAt(i + 2);
                        i++;
                        numbers[i] = "-" + numbers[i];
                    }
                }
                if (numbers.Count <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == "")
                    {
                        numbers[i + 1].Insert(0, "-");
                        numbers.RemoveAt(i);
                        i--;
                    }
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Count; i++)
                {
                    number -= new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }



        }
    }
}
