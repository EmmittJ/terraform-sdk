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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The model attribute.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => this.WithProperty("model", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformProperty<string>? SerialNumber
    {
        get => GetProperty<TerraformProperty<string>>("serial_number");
        set => this.WithProperty("serial_number", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
    /// The vendor attribute.
    /// </summary>
    public TerraformProperty<string>? Vendor
    {
        get => GetProperty<TerraformProperty<string>>("vendor");
        set => this.WithProperty("vendor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
