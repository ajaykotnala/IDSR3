using IdentityServer3.Core.Configuration;

namespace IDSR3.Configuration
{
    public class Factory
    {
        public static IdentityServerServiceFactory Configure(string connString)
        {
            var factory = new IdentityServerServiceFactory().UseInMemoryUsers(Users.Get()).UseInMemoryClients(Clients.Get()).UseInMemoryScopes(Scopes.Get());

            var idsrvOptions = new IdentityServerOptions
            {
                Factory = factory,
                SigningCertificate = Cert.Load(),
            };

            //app.UseIdentityServer(idsrvOptions);
            //var factory = new IdentityServerServiceFactory();

            //factory.RegisterConfigurationServices(efConfig);
            //factory.RegisterOperationalServices(efConfig);

            //var userService = new AvevaOnlineUserService();
            //factory.UserService = new Registration<IUserService>(resolver => userService);
            app.UseIdentityServer(idsrvOptions);
            return factory;
        }
    }
}