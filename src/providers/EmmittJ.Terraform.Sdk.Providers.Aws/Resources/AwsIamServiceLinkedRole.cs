using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_service_linked_role Terraform resource.
/// Manages a aws_iam_service_linked_role resource.
/// </summary>
public partial class AwsIamServiceLinkedRole(string name) : TerraformResource("aws_iam_service_linked_role", name)
{
    /// <summary>
    /// The aws_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsServiceName is required")]
    public required TerraformValue<string> AwsServiceName
    {
        get => GetArgument<TerraformValue<string>>("aws_service_name");
        set => SetArgument("aws_service_name", value);
    }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    public TerraformValue<string>? CustomSuffix
    {
        get => GetArgument<TerraformValue<string>>("custom_suffix");
        set => SetArgument("custom_suffix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
        => AsReference("unique_id");

}
