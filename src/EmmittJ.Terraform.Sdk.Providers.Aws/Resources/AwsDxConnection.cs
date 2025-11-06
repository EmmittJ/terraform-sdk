using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_connection resource.
/// </summary>
public class AwsDxConnection : TerraformResource
{
    public AwsDxConnection(string name) : base("aws_dx_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_device");
        this.DeclareOutput("has_logical_redundancy");
        this.DeclareOutput("jumbo_frame_capable");
        this.DeclareOutput("macsec_capable");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("partner_name");
        this.DeclareOutput("port_encryption_status");
        this.DeclareOutput("vlan_id");
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    public string? Bandwidth
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bandwidth")?.Value;
        set => this.WithProperty("bandwidth", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public string? EncryptionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_mode")?.Value;
        set => this.WithProperty("encryption_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public string? ProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provider_name")?.Value;
        set => this.WithProperty("provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_macsec attribute.
    /// </summary>
    public bool? RequestMacsec
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("request_macsec")?.Value;
        set => this.WithProperty("request_macsec", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformExpression HasLogicalRedundancy => this["has_logical_redundancy"];

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformExpression JumboFrameCapable => this["jumbo_frame_capable"];

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    public TerraformExpression MacsecCapable => this["macsec_capable"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformExpression PartnerName => this["partner_name"];

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    public TerraformExpression PortEncryptionStatus => this["port_encryption_status"];

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformExpression VlanId => this["vlan_id"];

}
