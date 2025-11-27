using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3control_access_grants_instance Terraform resource.
/// Manages a aws_s3control_access_grants_instance resource.
/// </summary>
public partial class AwsS3controlAccessGrantsInstance(string name) : TerraformResource("aws_s3control_access_grants_instance", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The identity_center_arn attribute.
    /// </summary>
    public TerraformValue<string>? IdentityCenterArn
    {
        get => new TerraformReference<string>(this, "identity_center_arn");
        set => SetArgument("identity_center_arn", value);
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
    /// The access_grants_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantsInstanceArn
    {
        get => new TerraformReference<string>(this, "access_grants_instance_arn");
    }

    /// <summary>
    /// The access_grants_instance_id attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantsInstanceId
    {
        get => new TerraformReference<string>(this, "access_grants_instance_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    public TerraformValue<string> IdentityCenterApplicationArn
    {
        get => new TerraformReference<string>(this, "identity_center_application_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
