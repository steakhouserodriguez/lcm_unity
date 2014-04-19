/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

package forseti2;
 
import java.io.*;
import java.util.*;
import lcm.lcm.*;
 
public final class header implements lcm.lcm.LCMEncodable
{
    public int seq;
    public double time;
 
    public header()
    {
    }
 
    public static final long LCM_FINGERPRINT;
    public static final long LCM_FINGERPRINT_BASE = 0xa4eee1da213128d1L;
 
    static {
        LCM_FINGERPRINT = _hashRecursive(new ArrayList<Class<?>>());
    }
 
    public static long _hashRecursive(ArrayList<Class<?>> classes)
    {
        if (classes.contains(forseti2.header.class))
            return 0L;
 
        classes.add(forseti2.header.class);
        long hash = LCM_FINGERPRINT_BASE
            ;
        classes.remove(classes.size() - 1);
        return (hash<<1) + ((hash>>63)&1);
    }
 
    public void encode(DataOutput outs) throws IOException
    {
        outs.writeLong(LCM_FINGERPRINT);
        _encodeRecursive(outs);
    }
 
    public void _encodeRecursive(DataOutput outs) throws IOException
    {
        outs.writeInt(this.seq); 
 
        outs.writeDouble(this.time); 
 
    }
 
    public header(byte[] data) throws IOException
    {
        this(new LCMDataInputStream(data));
    }
 
    public header(DataInput ins) throws IOException
    {
        if (ins.readLong() != LCM_FINGERPRINT)
            throw new IOException("LCM Decode error: bad fingerprint");
 
        _decodeRecursive(ins);
    }
 
    public static forseti2.header _decodeRecursiveFactory(DataInput ins) throws IOException
    {
        forseti2.header o = new forseti2.header();
        o._decodeRecursive(ins);
        return o;
    }
 
    public void _decodeRecursive(DataInput ins) throws IOException
    {
        this.seq = ins.readInt();
 
        this.time = ins.readDouble();
 
    }
 
    public forseti2.header copy()
    {
        forseti2.header outobj = new forseti2.header();
        outobj.seq = this.seq;
 
        outobj.time = this.time;
 
        return outobj;
    }
 
}
