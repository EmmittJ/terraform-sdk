using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_trust resource.
/// </summary>
public class AwsDirectoryServiceTrust : TerraformResource
{
    public AwsDirectoryServiceTrust(string name) : base("aws_directory_service_trust", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date_time");
        this.DeclareOutput("id");
        this.DeclareOutput("last_updated_date_time");
        this.DeclareOutput("state_last_updated_date_time");
        this.DeclareOutput("trust_state");
        this.DeclareOutput("trust_state_reason");
    }

    /// <summary>
    /// The conditional_forwarder_ip_addrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ConditionalForwarderIpAddrs
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("conditional_forwarder_ip_addrs");
        set => this.WithProperty("conditional_forwarder_ip_addrs", value);
    }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteAssociatedConditionalForwarder
    {
        get => GetProperty<TerraformProperty<bool>>("delete_associated_conditional_forwarder");
        set => this.WithProperty("delete_associated_conditional_forwarder", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainName is required")]
    public required TerraformProperty<string> RemoteDomainName
    {
        get => GetProperty<TerraformProperty<string>>("remote_domain_name");
        set => this.WithProperty("remote_domain_name", value);
    }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    public TerraformProperty<string>? SelectiveAuth
    {
        get => GetProperty<TerraformProperty<string>>("selective_auth");
        set => this.WithProperty("selective_auth", value);
    }

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    public required TerraformProperty<string> TrustDirection
    {
        get => GetProperty<TerraformProperty<string>>("trust_direction");
        set => this.WithProperty("trust_direction", value);
    }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustPassword is required")]
    public required TerraformProperty<string> TrustPassword
    {
        get => GetProperty<TerraformProperty<string>>("trust_password");
        set => this.WithProperty("trust_password", value);
    }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    public TerraformProperty<string>? TrustType
    {
        get => GetProperty<TerraformProperty<string>>("trust_type");
        set => this.WithProperty("trust_type", value);
    }

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    public TerraformExpression CreatedDateTime => this["created_date_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDateTime => this["last_updated_date_time"];

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression StateLastUpdatedDateTime => this["state_last_updated_date_time"];

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    public TerraformExpression TrustState => this["trust_state"];

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    public TerraformExpression TrustStateReason => this["trust_state_reason"];

}
