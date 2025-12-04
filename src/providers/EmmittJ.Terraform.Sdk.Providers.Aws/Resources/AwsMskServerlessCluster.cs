using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for client_authentication in AwsMskServerlessCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskServerlessClusterClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_authentication";

    /// <summary>
    /// Sasl block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sasl is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sasl block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sasl block(s) allowed")]
    public required TerraformList<AwsMskServerlessClusterClientAuthenticationBlockSaslBlock> Sasl
    {
        get => GetRequiredArgument<TerraformList<AwsMskServerlessClusterClientAuthenticationBlockSaslBlock>>("sasl");
        set => SetArgument("sasl", value);
    }

}

/// <summary>
/// Block type for sasl in AwsMskServerlessClusterClientAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskServerlessClusterClientAuthenticationBlockSaslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sasl";

    /// <summary>
    /// Iam block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Iam is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Iam block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iam block(s) allowed")]
    public required TerraformList<AwsMskServerlessClusterClientAuthenticationBlockSaslBlockIamBlock> Iam
    {
        get => GetRequiredArgument<TerraformList<AwsMskServerlessClusterClientAuthenticationBlockSaslBlockIamBlock>>("iam");
        set => SetArgument("iam", value);
    }

}

/// <summary>
/// Block type for iam in AwsMskServerlessClusterClientAuthenticationBlockSaslBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskServerlessClusterClientAuthenticationBlockSaslBlockIamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMskServerlessCluster.
/// Nesting mode: single
/// </summary>
public class AwsMskServerlessClusterTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_config in AwsMskServerlessCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskServerlessClusterVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? AsReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_msk_serverless_cluster Terraform resource.
/// Manages a aws_msk_serverless_cluster resource.
/// </summary>
public partial class AwsMskServerlessCluster(string name) : TerraformResource("aws_msk_serverless_cluster", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
        => AsReference("bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformValue<string> ClusterUuid
        => AsReference("cluster_uuid");

    /// <summary>
    /// ClientAuthentication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    public required TerraformList<AwsMskServerlessClusterClientAuthenticationBlock> ClientAuthentication
    {
        get => GetRequiredArgument<TerraformList<AwsMskServerlessClusterClientAuthenticationBlock>>("client_authentication");
        set => SetArgument("client_authentication", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMskServerlessClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMskServerlessClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    public required TerraformList<AwsMskServerlessClusterVpcConfigBlock> VpcConfig
    {
        get => GetRequiredArgument<TerraformList<AwsMskServerlessClusterVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
