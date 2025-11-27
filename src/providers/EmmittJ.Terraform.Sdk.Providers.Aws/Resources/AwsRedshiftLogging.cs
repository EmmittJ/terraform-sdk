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
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string>? LogDestinationType
    {
        get => new TerraformReference<string>(this, "log_destination_type");
        set => SetArgument("log_destination_type", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string>? LogExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_exports").ResolveNodes(ctx));
        set => SetArgument("log_exports", value);
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
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => new TerraformReference<string>(this, "s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
