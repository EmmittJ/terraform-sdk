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
        SetOutput("arn");
        SetOutput("bandwidth");
        SetOutput("description");
        SetOutput("provider_name");
        SetOutput("site_id");
        SetOutput("type");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("link_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_network_id");
        set => SetProperty("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    public required TerraformProperty<string> LinkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("link_id");
        set => SetProperty("link_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
