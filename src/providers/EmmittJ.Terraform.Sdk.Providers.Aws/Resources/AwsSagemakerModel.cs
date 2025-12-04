using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in AwsSagemakerModel.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    public TerraformValue<string>? ContainerHostname
    {
        get => GetArgument<TerraformValue<string>>("container_hostname");
        set => SetArgument("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string>? Environment
    {
        get => GetArgument<TerraformMap<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformValue<string>? InferenceSpecificationName
    {
        get => GetArgument<TerraformValue<string>>("inference_specification_name");
        set => SetArgument("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformValue<string>? ModelDataUrl
    {
        get => GetArgument<TerraformValue<string>>("model_data_url");
        set => SetArgument("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformValue<string>? ModelPackageName
    {
        get => GetArgument<TerraformValue<string>>("model_package_name");
        set => SetArgument("model_package_name", value);
    }

    /// <summary>
    /// ImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelContainerBlockImageConfigBlock>? ImageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlockImageConfigBlock>>("image_config");
        set => SetArgument("image_config", value);
    }

    /// <summary>
    /// ModelDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelDataSource block(s) allowed")]
    public TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlock>? ModelDataSource
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlock>>("model_data_source");
        set => SetArgument("model_data_source", value);
    }

    /// <summary>
    /// MultiModelConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiModelConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelContainerBlockMultiModelConfigBlock>? MultiModelConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlockMultiModelConfigBlock>>("multi_model_config");
        set => SetArgument("multi_model_config", value);
    }

}

/// <summary>
/// Block type for image_config in AwsSagemakerModelContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_config";

    /// <summary>
    /// The repository_access_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryAccessMode is required")]
    public required TerraformValue<string> RepositoryAccessMode
    {
        get => GetArgument<TerraformValue<string>>("repository_access_mode");
        set => SetArgument("repository_access_mode", value);
    }

    /// <summary>
    /// RepositoryAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RepositoryAuthConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelContainerBlockImageConfigBlockRepositoryAuthConfigBlock>? RepositoryAuthConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlockImageConfigBlockRepositoryAuthConfigBlock>>("repository_auth_config");
        set => SetArgument("repository_auth_config", value);
    }

}

/// <summary>
/// Block type for repository_auth_config in AwsSagemakerModelContainerBlockImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockImageConfigBlockRepositoryAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository_auth_config";

    /// <summary>
    /// The repository_credentials_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryCredentialsProviderArn is required")]
    public required TerraformValue<string> RepositoryCredentialsProviderArn
    {
        get => GetArgument<TerraformValue<string>>("repository_credentials_provider_arn");
        set => SetArgument("repository_credentials_provider_arn", value);
    }

}

/// <summary>
/// Block type for model_data_source in AwsSagemakerModelContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockModelDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_data_source";

    /// <summary>
    /// S3DataSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3DataSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3DataSource block(s) required")]
    public required TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlock> S3DataSource
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlock>>("s3_data_source");
        set => SetArgument("s3_data_source", value);
    }

}

/// <summary>
/// Block type for s3_data_source in AwsSagemakerModelContainerBlockModelDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_data_source";

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CompressionType is required")]
    public required TerraformValue<string> CompressionType
    {
        get => GetArgument<TerraformValue<string>>("compression_type");
        set => SetArgument("compression_type", value);
    }

    /// <summary>
    /// The s3_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3DataType is required")]
    public required TerraformValue<string> S3DataType
    {
        get => GetArgument<TerraformValue<string>>("s3_data_type");
        set => SetArgument("s3_data_type", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => GetArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// ModelAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelAccessConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock>? ModelAccessConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock>>("model_access_config");
        set => SetArgument("model_access_config", value);
    }

}

/// <summary>
/// Block type for model_access_config in AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_access_config";

    /// <summary>
    /// The accept_eula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptEula is required")]
    public required TerraformValue<bool> AcceptEula
    {
        get => GetArgument<TerraformValue<bool>>("accept_eula");
        set => SetArgument("accept_eula", value);
    }

}

/// <summary>
/// Block type for multi_model_config in AwsSagemakerModelContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlockMultiModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_model_config";

    /// <summary>
    /// The model_cache_setting attribute.
    /// </summary>
    public TerraformValue<string>? ModelCacheSetting
    {
        get => GetArgument<TerraformValue<string>>("model_cache_setting");
        set => SetArgument("model_cache_setting", value);
    }

}


/// <summary>
/// Block type for inference_execution_config in AwsSagemakerModel.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelInferenceExecutionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inference_execution_config";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for primary_container in AwsSagemakerModel.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_container";

    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    public TerraformValue<string>? ContainerHostname
    {
        get => GetArgument<TerraformValue<string>>("container_hostname");
        set => SetArgument("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string>? Environment
    {
        get => GetArgument<TerraformMap<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformValue<string>? InferenceSpecificationName
    {
        get => GetArgument<TerraformValue<string>>("inference_specification_name");
        set => SetArgument("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformValue<string>? ModelDataUrl
    {
        get => GetArgument<TerraformValue<string>>("model_data_url");
        set => SetArgument("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformValue<string>? ModelPackageName
    {
        get => GetArgument<TerraformValue<string>>("model_package_name");
        set => SetArgument("model_package_name", value);
    }

    /// <summary>
    /// ImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlockImageConfigBlock>? ImageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockImageConfigBlock>>("image_config");
        set => SetArgument("image_config", value);
    }

    /// <summary>
    /// ModelDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelDataSource block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlock>? ModelDataSource
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlock>>("model_data_source");
        set => SetArgument("model_data_source", value);
    }

    /// <summary>
    /// MultiModelConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiModelConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlockMultiModelConfigBlock>? MultiModelConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockMultiModelConfigBlock>>("multi_model_config");
        set => SetArgument("multi_model_config", value);
    }

}

/// <summary>
/// Block type for image_config in AwsSagemakerModelPrimaryContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_config";

    /// <summary>
    /// The repository_access_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryAccessMode is required")]
    public required TerraformValue<string> RepositoryAccessMode
    {
        get => GetArgument<TerraformValue<string>>("repository_access_mode");
        set => SetArgument("repository_access_mode", value);
    }

    /// <summary>
    /// RepositoryAuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RepositoryAuthConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlockImageConfigBlockRepositoryAuthConfigBlock>? RepositoryAuthConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockImageConfigBlockRepositoryAuthConfigBlock>>("repository_auth_config");
        set => SetArgument("repository_auth_config", value);
    }

}

/// <summary>
/// Block type for repository_auth_config in AwsSagemakerModelPrimaryContainerBlockImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockImageConfigBlockRepositoryAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository_auth_config";

    /// <summary>
    /// The repository_credentials_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryCredentialsProviderArn is required")]
    public required TerraformValue<string> RepositoryCredentialsProviderArn
    {
        get => GetArgument<TerraformValue<string>>("repository_credentials_provider_arn");
        set => SetArgument("repository_credentials_provider_arn", value);
    }

}

/// <summary>
/// Block type for model_data_source in AwsSagemakerModelPrimaryContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_data_source";

    /// <summary>
    /// S3DataSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3DataSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3DataSource block(s) required")]
    public required TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlock> S3DataSource
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlock>>("s3_data_source");
        set => SetArgument("s3_data_source", value);
    }

}

/// <summary>
/// Block type for s3_data_source in AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_data_source";

    /// <summary>
    /// The compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CompressionType is required")]
    public required TerraformValue<string> CompressionType
    {
        get => GetArgument<TerraformValue<string>>("compression_type");
        set => SetArgument("compression_type", value);
    }

    /// <summary>
    /// The s3_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3DataType is required")]
    public required TerraformValue<string> S3DataType
    {
        get => GetArgument<TerraformValue<string>>("s3_data_type");
        set => SetArgument("s3_data_type", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => GetArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// ModelAccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelAccessConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock>? ModelAccessConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock>>("model_access_config");
        set => SetArgument("model_access_config", value);
    }

}

/// <summary>
/// Block type for model_access_config in AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockModelDataSourceBlockS3DataSourceBlockModelAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_access_config";

    /// <summary>
    /// The accept_eula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptEula is required")]
    public required TerraformValue<bool> AcceptEula
    {
        get => GetArgument<TerraformValue<bool>>("accept_eula");
        set => SetArgument("accept_eula", value);
    }

}

/// <summary>
/// Block type for multi_model_config in AwsSagemakerModelPrimaryContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlockMultiModelConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_model_config";

    /// <summary>
    /// The model_cache_setting attribute.
    /// </summary>
    public TerraformValue<string>? ModelCacheSetting
    {
        get => GetArgument<TerraformValue<string>>("model_cache_setting");
        set => SetArgument("model_cache_setting", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsSagemakerModel.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_model Terraform resource.
/// Manages a aws_sagemaker_model resource.
/// </summary>
public partial class AwsSagemakerModel(string name) : TerraformResource("aws_sagemaker_model", name)
{
    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    public TerraformValue<bool>? EnableNetworkIsolation
    {
        get => GetArgument<TerraformValue<bool>>("enable_network_isolation");
        set => SetArgument("enable_network_isolation", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    /// Container block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerModelContainerBlock>? Container
    {
        get => GetArgument<TerraformList<AwsSagemakerModelContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// InferenceExecutionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelInferenceExecutionConfigBlock>? InferenceExecutionConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelInferenceExecutionConfigBlock>>("inference_execution_config");
        set => SetArgument("inference_execution_config", value);
    }

    /// <summary>
    /// PrimaryContainer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    public TerraformList<AwsSagemakerModelPrimaryContainerBlock>? PrimaryContainer
    {
        get => GetArgument<TerraformList<AwsSagemakerModelPrimaryContainerBlock>>("primary_container");
        set => SetArgument("primary_container", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsSagemakerModelVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerModelVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
