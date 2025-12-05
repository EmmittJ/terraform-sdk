using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource in AwsGlobalacceleratorCrossAccountAttachment.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCrossAccountAttachmentResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource";

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? EndpointId
    {
        get => GetArgument<TerraformValue<string>>("endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Represents a aws_globalaccelerator_cross_account_attachment Terraform resource.
/// Manages a aws_globalaccelerator_cross_account_attachment resource.
/// </summary>
public partial class AwsGlobalacceleratorCrossAccountAttachment(string name) : TerraformResource("aws_globalaccelerator_cross_account_attachment", name)
{
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
    /// The principals attribute.
    /// </summary>
    public TerraformSet<string>? Principals
    {
        get => GetArgument<TerraformSet<string>>("principals");
        set => SetArgument("principals", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => CreateReference("created_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => CreateReference("last_modified_time");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Resource block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>? Resource
    {
        get => GetArgument<TerraformSet<AwsGlobalacceleratorCrossAccountAttachmentResourceBlock>>("resource");
        set => SetArgument("resource", value);
    }

}
