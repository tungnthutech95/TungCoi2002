﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenThanhTung_lab456.Startup))]
namespace NguyenThanhTung_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
