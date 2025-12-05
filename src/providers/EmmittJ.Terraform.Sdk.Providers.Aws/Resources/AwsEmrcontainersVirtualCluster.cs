using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container_provider in AwsEmrcontainersVirtualCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersVirtualClusterContainerProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_provider";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Info block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Info is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Info block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Info block(s) allowed")]
    public required TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlock> Info
    {
        get => GetRequiredArgument<TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlock>>("info");
        set => SetArgument("info", value);
    }

}

/// <summary>
/// Block type for info in AwsEmrcontainersVirtualClusterContainerProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info";

    /// <summary>
    /// EksInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EksInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EksInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksInfo block(s) allowed")]
    public required TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlockEksInfoBlock> EksInfo
    {
        get => GetRequiredArgument<TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlockEksInfoBlock>>("eks_info");
        set => SetArgument("eks_info", value);
    }

}

/// <summary>
/// Block type for eks_info in AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersVirtualClusterContainerProviderBlockInfoBlockEksInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eks_info";

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEmrcontainersVirtualCluster.
/// Nesting mode: single
/// </summary>
public class AwsEmrcontainersVirtualClusterTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_emrcontainers_virtual_cluster Terraform resource.
/// Manages a aws_emrcontainers_virtual_cluster resource.
/// </summary>
public partial class AwsEmrcontainersVirtualCluster(string name) : TerraformResource("aws_emrcontainers_virtual_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// ContainerProvider block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerProvider is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContainerProvider block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerProvider block(s) allowed")]
    public required TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlock> ContainerProvider
    {
        get => GetRequiredArgument<TerraformList<AwsEmrcontainersVirtualClusterContainerProviderBlock>>("container_provider");
        set => SetArgument("container_provider", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEmrcontainersVirtualClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEmrcontainersVirtualClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
