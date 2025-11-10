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
        SetOutput("arn");
        SetOutput("aws_device");
        SetOutput("has_logical_redundancy");
        SetOutput("jumbo_frame_capable");
        SetOutput("macsec_capable");
        SetOutput("owner_account_id");
        SetOutput("partner_name");
        SetOutput("port_encryption_status");
        SetOutput("vlan_id");
        SetOutput("bandwidth");
        SetOutput("encryption_mode");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("provider_name");
        SetOutput("region");
        SetOutput("request_macsec");
        SetOutput("skip_destroy");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    public required TerraformProperty<string> Bandwidth
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bandwidth");
        set => SetProperty("bandwidth", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_mode");
        set => SetProperty("encryption_mode", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformProperty<string> ProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provider_name");
        set => SetProperty("provider_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The request_macsec attribute.
    /// </summary>
    public TerraformProperty<bool> RequestMacsec
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("request_macsec");
        set => SetProperty("request_macsec", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
