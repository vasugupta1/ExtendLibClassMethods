using SampleClassLib;

namespace ExtendLibClassExample;

public class UserWrapperObject
{
    public string DOB { get; set; } = default!;
    public Guid UserID { get; set; } = default!;
    public User @User { get; set; } = default!;
}