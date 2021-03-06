using FA.JustBlog.Data;
using FA.JustBlog.Data.Infrastructure;
using FA.JustBlog.MVC.Areas.Identity.Controllers;
using FA.JustBlog.MVC.Controllers;
using FA.JustBlog.Services.Entities;
using FA.JustBlog.Services.Interface;
using System;

using Unity;
using Unity.Injection;

namespace FA.JustBlog.MVC
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            container.RegisterSingleton<JustBlogDbContext, JustBlogDbContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<UsersAdminController>(new InjectionConstructor());
            container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<AccountController> (new Unity.Injection.InjectionConstructor());
            container.RegisterType<ManageController> (new Unity.Injection.InjectionConstructor());
            container.RegisterType<IPostServices, PostServices>();
            container.RegisterType<ICategoryServices, CategoryServices>();
            container.RegisterType<ITagServices, TagServices>();

        }
    }
}