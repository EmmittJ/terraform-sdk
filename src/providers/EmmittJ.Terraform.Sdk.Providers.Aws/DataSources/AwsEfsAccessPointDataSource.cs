using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_efs_access_point Terraform data source.
/// Retrieves information about a aws_efs_access_point.
/// </summary>
public partial class AwsEfsAccessPointDataSource(string name) : TerraformDataSource("aws_efs_access_point", name)
{
    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointId is required")]
    public required TerraformValue<string> AccessPointId
    {
        get => new TerraformReference<string>(this, "access_point_id");
        set => SetArgument("access_point_id", value);
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformValue<string> FileSystemArn
    {
        get => new TerraformReference<string>(this, "file_system_arn");
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The posix_user attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PosixUser
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "posix_user").ResolveNodes(ctx));
    }

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RootDirectory
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "root_directory").ResolveNodes(ctx));
    }

}
