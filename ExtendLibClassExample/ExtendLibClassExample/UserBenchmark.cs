using BenchmarkDotNet.Attributes;
using ExtendLibClassExample.Extensions;
using SampleClassLib;

namespace ExtendLibClassExample;

[MemoryDiagnoser]
public class UserBenchmark
{
    [Benchmark]
    public User ConditionalWeakTable()
    {
        var user = new User();
        user.Name = Guid.NewGuid().ToString();
        user.EmailAddress = Guid.NewGuid().ToString();
        user.LastName = Guid.NewGuid().ToString();
        user.GetProperty().DOB = Guid.NewGuid().ToString();
        user.GetProperty().UserID = Guid.NewGuid();
        return user;
    }
    
    [Benchmark]
    public UserWrapperObject WrapperUser()
        => new()
        {
            User = new()
            {
                EmailAddress = Guid.NewGuid().ToString(),
                LastName = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString()
            },
            DOB = Guid.NewGuid().ToString(),
            UserID = Guid.NewGuid()
        };
}