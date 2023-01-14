using System.Runtime.CompilerServices;
using SampleClassLib;

namespace ExtendLibClassExample.Extensions;

public static class UserObjectExtensions
{
    /*
     * What ConditionalWeakTable actually do is, it allows you to attach additional information to existing, managed, non-dynamic CLR objects,
     * where the keys are weakly referenced so a value is kept alive as long as the key is alive.
     * If you use dictionary for this then GC will be blocked as it will hold a strong reference to a key and value
     */
    private static readonly ConditionalWeakTable<User, UserExternalObjectProperties> Data
            = new ();
    public static UserExternalObjectProperties GetProperty(this User obj)
        => Data.GetOrCreateValue(obj);

}