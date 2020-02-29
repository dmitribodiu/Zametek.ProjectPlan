﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using Zametek.Access.ProjectPlan;
using Zametek.Contract.ProjectPlan;
using Zametek.Engine.ProjectPlan;
using Zametek.Manager.ProjectPlan;

namespace Zametek.Client.ProjectPlan.Wpf.Shell
{
    public partial class App
        : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDateTimeCalculator, DateTimeCalculator>();
            containerRegistry.Register<IFileDialogService, FileDialogService>();
            containerRegistry.Register<IProjectSettingService, ProjectSettingService>();

            containerRegistry.RegisterSingleton<IGraphProcessingEngine, GraphProcessingEngine>();
            containerRegistry.RegisterSingleton<IAssessingEngine, AssessingEngine>();
            containerRegistry.RegisterSingleton<IProjectManager, ProjectManager>();
            containerRegistry.RegisterSingleton<ISettingResourceAccess, SettingResourceAccess>();
            containerRegistry.RegisterSingleton<ISettingManager, SettingManager>();

            containerRegistry.RegisterSingleton<ICoreViewModel, CoreViewModel>();
            containerRegistry.RegisterSingleton<IEarnedValueChartManagerViewModel, EarnedValueChartManagerViewModel>();
            containerRegistry.RegisterSingleton<IResourceChartManagerViewModel, ResourceChartManagerViewModel>();
            containerRegistry.RegisterSingleton<IMetricsManagerViewModel, MetricsManagerViewModel>();
            containerRegistry.RegisterSingleton<IArrowGraphManagerViewModel, ArrowGraphManagerViewModel>();
            containerRegistry.RegisterSingleton<IGanttChartManagerViewModel, GanttChartManagerViewModel>();
            containerRegistry.RegisterSingleton<IActivitiesManagerViewModel, ActivitiesManagerViewModel>();
            containerRegistry.RegisterSingleton<IMainViewModel, MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ClientWpfModule>();
        }
    }
}