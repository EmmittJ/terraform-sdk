using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_logging Terraform resource.
/// Manages a aws_redshift_logging resource.
/// </summary>
public partial class AwsRedshiftLogging(string name) : TerraformResource("aws_redshift_logging", name)
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string>? LogDestinationType
    {
        get => GetArgument<TerraformValue<string>>("log_destination_type");
        set => SetArgument("log_destination_type", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string>? LogExports
    {
        get => GetArgument<TerraformSet<string>>("log_exports");
        set => SetArgument("log_exports", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

}
