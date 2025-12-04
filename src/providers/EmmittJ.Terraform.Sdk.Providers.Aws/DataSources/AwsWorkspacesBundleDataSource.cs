using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspaces_bundle Terraform data source.
/// Retrieves information about a aws_workspaces_bundle.
/// </summary>
public partial class AwsWorkspacesBundleDataSource(string name) : TerraformDataSource("aws_workspaces_bundle", name)
{
    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformValue<string>? BundleId
    {
        get => GetArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
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
    /// The compute_type attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeType
        => AsReference("compute_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The root_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RootStorage
        => AsReference("root_storage");

    /// <summary>
    /// The user_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserStorage
        => AsReference("user_storage");

}
