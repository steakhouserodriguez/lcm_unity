/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace forseti2
{
    public sealed class Schedule : LCM.LCM.LCMEncodable
    {
        public int num_matches;
        public forseti2.Match[] matches;
 
        public Schedule()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x90ee9e2bdd9ac3ecL;
 
        static Schedule()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("forseti2.Schedule"))
                return 0L;
 
            classes.Add("forseti2.Schedule");
            ulong hash = LCM_FINGERPRINT_BASE
                 + forseti2.Match._hashRecursive(classes)
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.num_matches); 
 
            for (int a = 0; a < this.num_matches; a++) {
                this.matches[a]._encodeRecursive(outs); 
            }
 
        }
 
        public Schedule(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public Schedule(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static forseti2.Schedule _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            forseti2.Schedule o = new forseti2.Schedule();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.num_matches = ins.ReadInt32();
 
            this.matches = new forseti2.Match[(int) num_matches];
            for (int a = 0; a < this.num_matches; a++) {
                this.matches[a] = forseti2.Match._decodeRecursiveFactory(ins);
            }
 
        }
 
        public forseti2.Schedule Copy()
        {
            forseti2.Schedule outobj = new forseti2.Schedule();
            outobj.num_matches = this.num_matches;
 
            outobj.matches = new forseti2.Match[(int) num_matches];
            for (int a = 0; a < this.num_matches; a++) {
                outobj.matches[a] = this.matches[a].Copy();
            }
 
            return outobj;
        }
    }
}
