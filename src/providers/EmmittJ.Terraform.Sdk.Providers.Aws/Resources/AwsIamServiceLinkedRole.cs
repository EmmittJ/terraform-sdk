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
        get => new TerraformReference<string>(this, "aws_service_name");
        set => SetArgument("aws_service_name", value);
    }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    public TerraformValue<string>? CustomSuffix
    {
        get => new TerraformReference<string>(this, "custom_suffix");
        set => SetArgument("custom_suffix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

}
