using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target in AwsDirectoryServiceSharedDirectory.
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceSharedDirectoryTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDirectoryServiceSharedDirectory.
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceSharedDirectoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_directory_service_shared_directory Terraform resource.
/// Manages a aws_directory_service_shared_directory resource.
/// </summary>
public partial class AwsDirectoryServiceSharedDirectory(string name) : TerraformResource("aws_directory_service_shared_directory", name)
{
    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
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
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => new TerraformReference<string>(this, "notes");
        set => SetArgument("notes", value);
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
    /// The shared_directory_id attribute.
    /// </summary>
    public TerraformValue<string> SharedDirectoryId
    {
        get => new TerraformReference<string>(this, "shared_directory_id");
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<AwsDirectoryServiceSharedDirectoryTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<AwsDirectoryServiceSharedDirectoryTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDirectoryServiceSharedDirectoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDirectoryServiceSharedDirectoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
