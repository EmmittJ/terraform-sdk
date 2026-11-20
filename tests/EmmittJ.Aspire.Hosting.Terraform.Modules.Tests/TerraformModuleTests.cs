// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform.Modules;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules.Tests;

public class TerraformModuleTests
{
    [Fact]
    public void AddTerraformModule_ResolvesPathRelativeToAppHost()
    {
        var builder = DistributedApplication.CreateBuilder();

        var module = builder.AddTerraformModule("network", "./infra/network");

        Assert.Equal(Path.GetFullPath("./infra/network", builder.AppHostDirectory), module.Resource.ModuleDirectory);
    }

    [Fact]
    public void GetOutput_UsesExactTerraformOutputName()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformModule("network", "./infra/network");

        var output = module.GetOutput("network_id");

        Assert.Equal("network_id", output.Name);
        Assert.Equal("{network.outputs.network_id}", output.ValueExpression);
    }

    [Fact]
    public async Task GetOutput_InRunMode_ExplainsOutputsNeedDeploy()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformModule("network", "./infra/network");

        var ex = await Assert.ThrowsAsync<DistributedApplicationException>(
            async () => await module.GetOutput("network_id").GetValueAsync());

        Assert.Contains("IsPublishMode", ex.Message);
    }

    [Fact]
    public void WithVariable_RecordsValuesUnderTerraformVariableName()
    {
        var builder = DistributedApplication.CreateBuilder();
        var network = builder.AddTerraformModule("network", "./infra/network");
        var app = builder.AddTerraformModule("app", "./infra/app")
            .WithVariable("network_id", network.GetOutput("network_id"))
            .WithVariable("callback_url", "https://example.com");

        Assert.Equal(["callback_url", "network_id"], app.Resource.Variables.Keys.Order());
    }

    [Fact]
    public void AddTerraformModule_InRunMode_IsNotAddedToModel()
    {
        var builder = DistributedApplication.CreateBuilder();

        builder.AddTerraformModule("network", "./infra/network");

        Assert.Empty(builder.Resources.OfType<TerraformModuleResource>());
    }

    [Fact]
    public void AddTerraformModule_InPublishMode_IsAddedToModelWithPipelineSteps()
    {
        var builder = DistributedApplication.CreateBuilder(["--operation", "publish", "--output-path", Path.GetTempPath()]);

        var module = builder.AddTerraformModule("network", "./infra/network");

        Assert.Contains(module.Resource, builder.Resources);
        Assert.True(module.Resource.Annotations.Count > 0);
    }
}
