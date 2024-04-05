using RestWithASP_NET.Data.VO;

namespace RestWithASP_NET.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
