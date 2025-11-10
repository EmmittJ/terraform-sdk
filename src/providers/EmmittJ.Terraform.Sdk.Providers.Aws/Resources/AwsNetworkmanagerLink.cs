using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for bandwidth in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerLinkBandwidthBlock : TerraformBlock
{
    /// <summary>
    /// The download_speed attribute.
    /// </summary>
    public TerraformProperty<double>? DownloadSpeed
    {
        get => GetProperty<TerraformProperty<double>>("download_speed");
        set => WithProperty("download_speed", value);
    }

    /// <summary>
    /// The upload_speed attribute.
    /// </summary>
    public TerraformProperty<double>? UploadSpeed
    {
        get => GetProperty<TerraformProperty<double>>("upload_speed");
        set => WithProperty("upload_speed", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerLinkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_link resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerLink : TerraformResource
{
    public AwsNetworkmanagerLink(string name) : base("aws_networkmanager_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("global_network_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteId is required")]
    public required TerraformProperty<string> SiteId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("site_id");
        set => this.WithProperty("site_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
    /// Block for bandwidth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Bandwidth block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bandwidth block(s) allowed")]
    public List<AwsNetworkmanagerLinkBandwidthBlock>? Bandwidth
    {
        get => GetProperty<List<AwsNetworkmanagerLinkBandwidthBlock>>("bandwidth");
        set => this.WithProperty("bandwidth", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerLinkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerLinkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
