using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_directory_service_trust Terraform resource.
/// Manages a aws_directory_service_trust resource.
/// </summary>
public partial class AwsDirectoryServiceTrust(string name) : TerraformResource("aws_directory_service_trust", name)
{
    /// <summary>
    /// The conditional_forwarder_ip_addrs attribute.
    /// </summary>
    public TerraformSet<string>? ConditionalForwarderIpAddrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "conditional_forwarder_ip_addrs").ResolveNodes(ctx));
        set => SetArgument("conditional_forwarder_ip_addrs", value);
    }

    /// <summary>
    /// The delete_associated_conditional_forwarder attribute.
    /// </summary>
    public TerraformValue<bool> DeleteAssociatedConditionalForwarder
    {
        get => new TerraformReference<bool>(this, "delete_associated_conditional_forwarder");
        set => SetArgument("delete_associated_conditional_forwarder", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainName is required")]
    public required TerraformValue<string> RemoteDomainName
    {
        get => new TerraformReference<string>(this, "remote_domain_name");
        set => SetArgument("remote_domain_name", value);
    }

    /// <summary>
    /// The selective_auth attribute.
    /// </summary>
    public TerraformValue<string> SelectiveAuth
    {
        get => new TerraformReference<string>(this, "selective_auth");
        set => SetArgument("selective_auth", value);
    }

    /// <summary>
    /// The trust_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    public required TerraformValue<string> TrustDirection
    {
        get => new TerraformReference<string>(this, "trust_direction");
        set => SetArgument("trust_direction", value);
    }

    /// <summary>
    /// The trust_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustPassword is required")]
    public required TerraformValue<string> TrustPassword
    {
        get => new TerraformReference<string>(this, "trust_password");
        set => SetArgument("trust_password", value);
    }

    /// <summary>
    /// The trust_type attribute.
    /// </summary>
    public TerraformValue<string> TrustType
    {
        get => new TerraformReference<string>(this, "trust_type");
        set => SetArgument("trust_type", value);
    }

    /// <summary>
    /// The created_date_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedDateTime
    {
        get => new TerraformReference<string>(this, "created_date_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDateTime
    {
        get => new TerraformReference<string>(this, "last_updated_date_time");
    }

    /// <summary>
    /// The state_last_updated_date_time attribute.
    /// </summary>
    public TerraformValue<string> StateLastUpdatedDateTime
    {
        get => new TerraformReference<string>(this, "state_last_updated_date_time");
    }

    /// <summary>
    /// The trust_state attribute.
    /// </summary>
    public TerraformValue<string> TrustState
    {
        get => new TerraformReference<string>(this, "trust_state");
    }

    /// <summary>
    /// The trust_state_reason attribute.
    /// </summary>
    public TerraformValue<string> TrustStateReason
    {
        get => new TerraformReference<string>(this, "trust_state_reason");
    }

}
