using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDirectoryServiceSharedDirectoryAccepter.
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_directory_service_shared_directory_accepter Terraform resource.
/// Manages a aws_directory_service_shared_directory_accepter resource.
/// </summary>
public partial class AwsDirectoryServiceSharedDirectoryAccepter(string name) : TerraformResource("aws_directory_service_shared_directory_accepter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedDirectoryId is required")]
    public required TerraformValue<string> SharedDirectoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("shared_directory_id");
        set => SetArgument("shared_directory_id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string> Method
        => AsReference("method");

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformValue<string> Notes
        => AsReference("notes");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

    /// <summary>
    /// The owner_directory_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerDirectoryId
        => AsReference("owner_directory_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
