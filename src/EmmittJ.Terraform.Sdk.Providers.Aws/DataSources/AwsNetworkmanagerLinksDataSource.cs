using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_links.
/// </summary>
public class AwsNetworkmanagerLinksDataSource : TerraformDataSource
{
    public AwsNetworkmanagerLinksDataSource(string name) : base("aws_networkmanager_links", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ids");
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
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
    /// The provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderName
    {
        get => GetProperty<TerraformProperty<string>>("provider_name");
        set => this.WithProperty("provider_name", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformProperty<string>? SiteId
    {
        get => GetProperty<TerraformProperty<string>>("site_id");
        set => this.WithProperty("site_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
