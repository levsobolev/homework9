namespace fortumakov.interfaces
{
    public interface ICipher
    {
        string encode(string str);
        string decode(string str);
    }
}