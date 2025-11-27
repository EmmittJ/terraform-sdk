using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mapping in AwsImagebuilderImageRecipe.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageRecipeBlockDeviceMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block_device_mapping";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformValue<bool> NoDevice
    {
        get => new TerraformReference<bool>(this, "no_device");
        set => SetArgument("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualName
    {
        get => new TerraformReference<string>(this, "virtual_name");
        set => SetArgument("virtual_name", value);
    }

    /// <summary>
    /// Ebs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ebs block(s) allowed")]
    public TerraformList<AwsImagebuilderImageRecipeBlockDeviceMappingBlockEbsBlock>? Ebs
    {
        get => GetArgument<TerraformList<AwsImagebuilderImageRecipeBlockDeviceMappingBlockEbsBlock>>("ebs");
        set => SetArgument("ebs", value);
    }

}

/// <summary>
/// Block type for ebs in AwsImagebuilderImageRecipeBlockDeviceMappingBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeBlockDeviceMappingBlockEbsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<string>? DeleteOnTermination
    {
        get => new TerraformReference<string>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<string>? Encrypted
    {
        get => new TerraformReference<string>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for component in AwsImagebuilderImageRecipe.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeComponentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component";

    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    public required TerraformValue<string> ComponentArn
    {
        get => new TerraformReference<string>(this, "component_arn");
        set => SetArgument("component_arn", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderImageRecipeComponentBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsImagebuilderImageRecipeComponentBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsImagebuilderImageRecipeComponentBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageRecipeComponentBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for systems_manager_agent in AwsImagebuilderImageRecipe.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeSystemsManagerAgentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "systems_manager_agent";

    /// <summary>
    /// The uninstall_after_build attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UninstallAfterBuild is required")]
    public required TerraformValue<bool> UninstallAfterBuild
    {
        get => new TerraformReference<bool>(this, "uninstall_after_build");
        set => SetArgument("uninstall_after_build", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_image_recipe Terraform resource.
/// Manages a aws_imagebuilder_image_recipe resource.
/// </summary>
public partial class AwsImagebuilderImageRecipe(string name) : TerraformResource("aws_imagebuilder_image_recipe", name)
{
    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    public TerraformMap<string>? AmiTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "ami_tags").ResolveNodes(ctx));
        set => SetArgument("ami_tags", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    public required TerraformValue<string> ParentImage
    {
        get => new TerraformReference<string>(this, "parent_image");
        set => SetArgument("parent_image", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
    {
        get => new TerraformReference<string>(this, "user_data_base64");
        set => SetArgument("user_data_base64", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string>? WorkingDirectory
    {
        get => new TerraformReference<string>(this, "working_directory");
        set => SetArgument("working_directory", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// BlockDeviceMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>? BlockDeviceMapping
    {
        get => GetArgument<TerraformSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>>("block_device_mapping");
        set => SetArgument("block_device_mapping", value);
    }

    /// <summary>
    /// Component block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public required TerraformList<AwsImagebuilderImageRecipeComponentBlock> Component
    {
        get => GetRequiredArgument<TerraformList<AwsImagebuilderImageRecipeComponentBlock>>("component");
        set => SetArgument("component", value);
    }

    /// <summary>
    /// SystemsManagerAgent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemsManagerAgent block(s) allowed")]
    public TerraformList<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>? SystemsManagerAgent
    {
        get => GetArgument<TerraformList<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>>("systems_manager_agent");
        set => SetArgument("systems_manager_agent", value);
    }

}
