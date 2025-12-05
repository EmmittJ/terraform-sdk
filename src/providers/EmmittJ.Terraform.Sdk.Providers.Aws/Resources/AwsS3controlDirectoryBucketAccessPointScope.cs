using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in AwsS3controlDirectoryBucketAccessPointScope.
/// Nesting mode: list
/// </summary>
public class AwsS3controlDirectoryBucketAccessPointScopeScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<string>? Permissions
    {
        get => GetArgument<TerraformList<string>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The prefixes attribute.
    /// </summary>
    public TerraformList<string>? Prefixes
    {
        get => GetArgument<TerraformList<string>>("prefixes");
        set => SetArgument("prefixes", value);
    }

}


/// <summary>
/// Represents a aws_s3control_directory_bucket_access_point_scope Terraform resource.
/// Manages a aws_s3control_directory_bucket_access_point_scope resource.
/// </summary>
public partial class AwsS3controlDirectoryBucketAccessPointScope(string name) : TerraformResource("aws_s3control_directory_bucket_access_point_scope", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}
