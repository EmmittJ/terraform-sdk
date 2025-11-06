using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_device resource.
/// </summary>
public class AwsNetworkmanagerDevice : TerraformResource
{
    public AwsNetworkmanagerDevice(string name) : base("aws_networkmanager_device", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public string? GlobalNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_id")?.Value;
        set => this.WithProperty("global_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model attribute.
    /// </summary>
    public string? Model
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model")?.Value;
        set => this.WithProperty("model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public string? SerialNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("serial_number")?.Value;
        set => this.WithProperty("serial_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public string? SiteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("site_id")?.Value;
        set => this.WithProperty("site_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public string? Vendor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vendor")?.Value;
        set => this.WithProperty("vendor", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
