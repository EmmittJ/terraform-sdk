using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_profile.
/// </summary>
public class AzurermCdnFrontdoorProfileDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorProfileDataSource(string name) : base("azurerm_cdn_frontdoor_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("identity");
        this.DeclareOutput("log_scrubbing_rule");
        this.DeclareOutput("resource_guid");
        this.DeclareOutput("response_timeout_seconds");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The log_scrubbing_rule attribute.
    /// </summary>
    public TerraformExpression LogScrubbingRule => this["log_scrubbing_rule"];

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformExpression ResourceGuid => this["resource_guid"];

    /// <summary>
    /// The response_timeout_seconds attribute.
    /// </summary>
    public TerraformExpression ResponseTimeoutSeconds => this["response_timeout_seconds"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
