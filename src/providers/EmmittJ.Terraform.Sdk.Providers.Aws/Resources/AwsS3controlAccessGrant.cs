using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_grants_location_configuration in AwsS3controlAccessGrant.
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_grants_location_configuration";

    /// <summary>
    /// The s3_sub_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3SubPrefix
    {
        get => new TerraformReference<string>(this, "s3_sub_prefix");
        set => SetArgument("s3_sub_prefix", value);
    }

}


/// <summary>
/// Block type for grantee in AwsS3controlAccessGrant.
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantGranteeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grantee";

    /// <summary>
    /// The grantee_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeIdentifier is required")]
    public required TerraformValue<string> GranteeIdentifier
    {
        get => new TerraformReference<string>(this, "grantee_identifier");
        set => SetArgument("grantee_identifier", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeType is required")]
    public required TerraformValue<string> GranteeType
    {
        get => new TerraformReference<string>(this, "grantee_type");
        set => SetArgument("grantee_type", value);
    }

}


/// <summary>
/// Represents a aws_s3control_access_grant Terraform resource.
/// Manages a aws_s3control_access_grant resource.
/// </summary>
public partial class AwsS3controlAccessGrant(string name) : TerraformResource("aws_s3control_access_grant", name)
{
    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessGrantsLocationId is required")]
    public required TerraformValue<string> AccessGrantsLocationId
    {
        get => new TerraformReference<string>(this, "access_grants_location_id");
        set => SetArgument("access_grants_location_id", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformValue<string> Permission
    {
        get => new TerraformReference<string>(this, "permission");
        set => SetArgument("permission", value);
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
    /// The s3_prefix_type attribute.
    /// </summary>
    public TerraformValue<string>? S3PrefixType
    {
        get => new TerraformReference<string>(this, "s3_prefix_type");
        set => SetArgument("s3_prefix_type", value);
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
    /// The access_grant_arn attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantArn
    {
        get => new TerraformReference<string>(this, "access_grant_arn");
    }

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantId
    {
        get => new TerraformReference<string>(this, "access_grant_id");
    }

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    public TerraformValue<string> GrantScope
    {
        get => new TerraformReference<string>(this, "grant_scope");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// AccessGrantsLocationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>? AccessGrantsLocationConfiguration
    {
        get => GetArgument<TerraformList<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>>("access_grants_location_configuration");
        set => SetArgument("access_grants_location_configuration", value);
    }

    /// <summary>
    /// Grantee block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3controlAccessGrantGranteeBlock>? Grantee
    {
        get => GetArgument<TerraformList<AwsS3controlAccessGrantGranteeBlock>>("grantee");
        set => SetArgument("grantee", value);
    }

}
