using System;
using System.Collections;
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
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))            
                return false;            
            else
            {
                VeryLong vl2 = (VeryLong)obj;
                return vl2.ToString()==ToString();
            }
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
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
            return vl1.ToString() == vl2.ToString();
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
            else if (vl1< 0 && vl2< 0)
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
            if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return vl2 + -vl1;
                else
                    return vl1 + -vl2;
            else if (vl1< 0 && vl2< 0)
                return vl2 - -vl1;

            while (vl2.value.Count < vl1.value.Count)
            {
                vl2.value.Insert(0, 0);
            }
            for (int i = vl1.value.Count - 1; i >= 0; i--)
            {
                
                if (vl1.value[i] - vl2.value[i] >= 0)
                    vl1.value[i] -= vl2.value[i];
                else
                {
                    if (i != 0)
                    {   
                            vl1.value[i] -= vl2.value[i] - (int)Math.Pow(10, lbase);
                            vl1.value[i - 1]--;                        
                    }
                    else
                    {
                        vl1.value[i] -= vl2.value[i];
                        if (vl1.value.Count < vl2.value.Count && vl1.value[i] < 0)
                            vl1.value[i] *= -1;
                    }
                }
                if (vl1.value.Count < vl2.value.Count)
                {
                    vl1.value.Insert(0, 0);
                    i++;
                }
                
            }
            for (int i = 0; i < vl1.value.Count; i++)
            {
                if (vl1.value[i] == 0)
                    vl1.value.RemoveAt(0);
                else
                    break;

            }
            return vl1;
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
                return new VeryLong(0);
            return KaratsubaMultiply(vl1, vl2);
        }        
        #region KaratsubaMultiply
        static VeryLong KaratsubaMultiply(VeryLong vl1, VeryLong vl2)
        {
            int cutPos = GetCutPosition(vl1, vl2);
            string a = GetFirstPart(vl1, cutPos);
            string b = GetSecondPart(vl1, cutPos);
            string c = GetFirstPart(vl2, cutPos);
            string d = GetSecondPart(vl2, cutPos);
            string ac = KaratsubaMultiply(a, c);
            string bd = KaratsubaMultiply(b, d);
            string ab_cd = KaratsubaMultiply(StringAddtion(a, b), StringAddtion(c, d));
            return CalculateResult(ac, bd, ab_cd, b.Length + d.Length);
            /*List<int> result;
            if (vl1.value.Count <= vl2.value.Count)
            {
                result = vl2.value;
                for (int i = vl1.value.Count - 1; i >= 0; i--)
                {

                }

            }
            else
            {
                result = vl1.value;
                for (int i = vl2.value.Count - 1; i >= 0; i--)
                {

                }
            }
            return new VeryLong(result);*/
        }


        static string CalculateResult(string ac, string bd, string ab_cd, int padding)
        {
            string term0 = StringSubtraction(StringSubtraction(ab_cd, ac), bd);
            string term1 = term0.PadRight(term0.Length + padding / 2, '0');
            string term2 = ac.PadRight(ac.Length + padding, '0');
            return StringAddtion(StringAddtion(term1, term2), bd);
        }

        static string GetFirstPart(string str, int cutPos)
        {
            return str.Remove(str.Length - cutPos);
        }

        static string GetSecondPart(string str, int cutPos)
        {
            return str.Substring(str.Length - cutPos);
        }

        static int GetCutPosition(string first, string second)
        {
            int min = Math.Min(first.Length, second.Length);
            if (min == 1)
                return 1;
            if (min % 2 == 0)
                return min / 2;
            return min / 2 + 1;
        }

        static string StringAddtion(string a, string b)
        {
            string result = "";
            //a is always the smallest in length
            if (a.Length > b.Length)
            {
                Swap(ref a, ref b);
            }
            a = a.PadLeft(b.Length, '0');
            int length = a.Length;
            int carry = 0, res;
            for (int i = length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(a.Substring(i, 1));
                int num2 = int.Parse(b.Substring(i, 1));
                res = (num1 + num2 + carry) % 10;
                carry = (num1 + num2 + carry) / 10;
                result = result.Insert(0, res.ToString());
            }
            if (carry != 0)
                result = result.Insert(0, carry.ToString());
            return SanitizeResult(result);
        }

        static string StringSubtraction(string a, string b)
        {
            bool resultNegative = false;
            string result = "";
            //a should be the larger number
            if (StringIsSmaller(a, b))
            {
                Swap(ref a, ref b);
                resultNegative = true;
            }
            b = b.PadLeft(a.Length, '0');
            int length = a.Length;
            int carry = 0, res;
            for (int i = length - 1; i >= 0; i--)
            {
                bool nextCarry = false;
                int num1 = int.Parse(a.Substring(i, 1));
                int num2 = int.Parse(b.Substring(i, 1));
                if (num1 - carry < num2)
                {
                    num1 = num1 + 10;
                    nextCarry = true;
                }
                res = (num1 - num2 - carry);
                result = result.Insert(0, res.ToString());
                if (nextCarry)
                    carry = 1;
                else
                    carry = 0;
            }
            result = SanitizeResult(result);
            if (resultNegative)
                return result.Insert(0, "-");
            return result;
        }

        static bool StringIsSmaller(string a, string b)
        {
            if (a.Length < b.Length)
                return true;
            if (a.Length > b.Length)
                return false;
            char[] arrayA = a.ToCharArray();
            char[] arrayB = b.ToCharArray();
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] < arrayB[i])
                    return true;
                if (arrayA[i] > arrayB[i])
                    return false;
            }
            return false;
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static string SanitizeResult(string result)
        {
            result = result.TrimStart(new char[] { '0' });
            if (result.Length == 0)
                result = "0";
            return result;
        }
        #endregion
        public static VeryLong operator /(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 == 0)
                return new VeryLong(0);
            else if (vl2 == 0)
                throw new DivideByZeroException();
            else if (vl1 < 0 ^ vl2 < 0)
                if (vl1 < 0)
                    return -(vl2 / -vl1);
                else
                    return -(vl1 / -vl2);
            else if (vl1 < 0 && vl2 < 0)
                return -vl2 / -vl1;
            int up = lbase;
            int down = 0;
            while (up - down != 1)
            {
                if (vl2 * ((down + up) / 2) < vl1)
                    down += ((down + up) / 2);
                else if (vl2 * ((down + up) / 2) > vl1)
                    up -= ((down + up) / 2);
                else
                    return vl2 * ((down + up) / 2);
            }
            return vl2 * down;
        }
        public static VeryLong operator %(VeryLong vl1, VeryLong vl2)
        {
            if (vl1 == 0)
                return new VeryLong(0);
            else if (vl2 == 0)
                throw new DivideByZeroException();
            vl1 = Mod(vl1);
            vl2 = Mod(vl2);
            int up = lbase;
            int down = 0;
            while (up - down != 1)
            {
                if (vl2 * ((down + up) / 2) < vl1)
                    down += ((down + up) / 2);
                else if (vl2 * ((down + up) / 2) > vl1)
                    up -= ((down + up) / 2);
                else
                    return new VeryLong(0);
            }
            return vl1 - vl2 * down;
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
