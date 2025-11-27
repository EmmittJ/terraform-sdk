using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLbTrustStore.
/// Nesting mode: single
/// </summary>
public class AwsLbTrustStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_lb_trust_store Terraform resource.
/// Manages a aws_lb_trust_store resource.
/// </summary>
public partial class AwsLbTrustStore(string name) : TerraformResource("aws_lb_trust_store", name)
{
    /// <summary>
    /// The ca_certificates_bundle_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatesBundleS3Bucket is required")]
    public required TerraformValue<string> CaCertificatesBundleS3Bucket
    {
        get => new TerraformReference<string>(this, "ca_certificates_bundle_s3_bucket");
        set => SetArgument("ca_certificates_bundle_s3_bucket", value);
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaCertificatesBundleS3Key is required")]
    public required TerraformValue<string> CaCertificatesBundleS3Key
    {
        get => new TerraformReference<string>(this, "ca_certificates_bundle_s3_key");
        set => SetArgument("ca_certificates_bundle_s3_key", value);
    }

    /// <summary>
    /// The ca_certificates_bundle_s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? CaCertificatesBundleS3ObjectVersion
    {
        get => new TerraformReference<string>(this, "ca_certificates_bundle_s3_object_version");
        set => SetArgument("ca_certificates_bundle_s3_object_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
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

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
    {
        get => new TerraformReference<string>(this, "arn_suffix");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTrustStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTrustStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
