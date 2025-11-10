using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_link.
/// </summary>
public class AwsNetworkmanagerLinkDataSource : TerraformDataSource
{
    public AwsNetworkmanagerLinkDataSource(string name) : base("aws_networkmanager_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bandwidth");
        this.DeclareOutput("description");
        this.DeclareOutput("provider_name");
        this.DeclareOutput("site_id");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
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
    /// The link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    public required TerraformProperty<string> LinkId
    {
        get => GetProperty<TerraformProperty<string>>("link_id");
        set => this.WithProperty("link_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    public TerraformExpression Bandwidth => this["bandwidth"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformExpression ProviderName => this["provider_name"];

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformExpression SiteId => this["site_id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
