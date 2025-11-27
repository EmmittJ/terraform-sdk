using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_hsm_configuration Terraform resource.
/// Manages a aws_redshift_hsm_configuration resource.
/// </summary>
public partial class AwsRedshiftHsmConfiguration(string name) : TerraformResource("aws_redshift_hsm_configuration", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmConfigurationIdentifier is required")]
    public required TerraformValue<string> HsmConfigurationIdentifier
    {
        get => new TerraformReference<string>(this, "hsm_configuration_identifier");
        set => SetArgument("hsm_configuration_identifier", value);
    }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmIpAddress is required")]
    public required TerraformValue<string> HsmIpAddress
    {
        get => new TerraformReference<string>(this, "hsm_ip_address");
        set => SetArgument("hsm_ip_address", value);
    }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionName is required")]
    public required TerraformValue<string> HsmPartitionName
    {
        get => new TerraformReference<string>(this, "hsm_partition_name");
        set => SetArgument("hsm_partition_name", value);
    }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionPassword is required")]
    public required TerraformValue<string> HsmPartitionPassword
    {
        get => new TerraformReference<string>(this, "hsm_partition_password");
        set => SetArgument("hsm_partition_password", value);
    }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmServerPublicCertificate is required")]
    public required TerraformValue<string> HsmServerPublicCertificate
    {
        get => new TerraformReference<string>(this, "hsm_server_public_certificate");
        set => SetArgument("hsm_server_public_certificate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
