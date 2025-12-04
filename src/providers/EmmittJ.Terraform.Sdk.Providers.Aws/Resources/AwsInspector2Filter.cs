using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_criteria in AwsInspector2Filter.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_criteria";

    /// <summary>
    /// AwsAccountId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockAwsAccountIdBlock>? AwsAccountId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockAwsAccountIdBlock>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// CodeRepositoryProjectName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProjectNameBlock>? CodeRepositoryProjectName
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProjectNameBlock>>("code_repository_project_name");
        set => SetArgument("code_repository_project_name", value);
    }

    /// <summary>
    /// CodeRepositoryProviderType block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProviderTypeBlock>? CodeRepositoryProviderType
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProviderTypeBlock>>("code_repository_provider_type");
        set => SetArgument("code_repository_provider_type", value);
    }

    /// <summary>
    /// CodeVulnerabilityDetectorName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorNameBlock>? CodeVulnerabilityDetectorName
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorNameBlock>>("code_vulnerability_detector_name");
        set => SetArgument("code_vulnerability_detector_name", value);
    }

    /// <summary>
    /// CodeVulnerabilityDetectorTags block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorTagsBlock>? CodeVulnerabilityDetectorTags
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorTagsBlock>>("code_vulnerability_detector_tags");
        set => SetArgument("code_vulnerability_detector_tags", value);
    }

    /// <summary>
    /// CodeVulnerabilityFilePath block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityFilePathBlock>? CodeVulnerabilityFilePath
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityFilePathBlock>>("code_vulnerability_file_path");
        set => SetArgument("code_vulnerability_file_path", value);
    }

    /// <summary>
    /// ComponentId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockComponentIdBlock>? ComponentId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockComponentIdBlock>>("component_id");
        set => SetArgument("component_id", value);
    }

    /// <summary>
    /// ComponentType block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockComponentTypeBlock>? ComponentType
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockComponentTypeBlock>>("component_type");
        set => SetArgument("component_type", value);
    }

    /// <summary>
    /// Ec2InstanceImageId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceImageIdBlock>? Ec2InstanceImageId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceImageIdBlock>>("ec2_instance_image_id");
        set => SetArgument("ec2_instance_image_id", value);
    }

    /// <summary>
    /// Ec2InstanceSubnetId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceSubnetIdBlock>? Ec2InstanceSubnetId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceSubnetIdBlock>>("ec2_instance_subnet_id");
        set => SetArgument("ec2_instance_subnet_id", value);
    }

    /// <summary>
    /// Ec2InstanceVpcId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceVpcIdBlock>? Ec2InstanceVpcId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEc2InstanceVpcIdBlock>>("ec2_instance_vpc_id");
        set => SetArgument("ec2_instance_vpc_id", value);
    }

    /// <summary>
    /// EcrImageArchitecture block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageArchitectureBlock>? EcrImageArchitecture
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageArchitectureBlock>>("ecr_image_architecture");
        set => SetArgument("ecr_image_architecture", value);
    }

    /// <summary>
    /// EcrImageHash block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageHashBlock>? EcrImageHash
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageHashBlock>>("ecr_image_hash");
        set => SetArgument("ecr_image_hash", value);
    }

    /// <summary>
    /// EcrImageInUseCount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageInUseCountBlock>? EcrImageInUseCount
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageInUseCountBlock>>("ecr_image_in_use_count");
        set => SetArgument("ecr_image_in_use_count", value);
    }

    /// <summary>
    /// EcrImageLastInUseAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageLastInUseAtBlock>? EcrImageLastInUseAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageLastInUseAtBlock>>("ecr_image_last_in_use_at");
        set => SetArgument("ecr_image_last_in_use_at", value);
    }

    /// <summary>
    /// EcrImagePushedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImagePushedAtBlock>? EcrImagePushedAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImagePushedAtBlock>>("ecr_image_pushed_at");
        set => SetArgument("ecr_image_pushed_at", value);
    }

    /// <summary>
    /// EcrImageRegistry block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageRegistryBlock>? EcrImageRegistry
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageRegistryBlock>>("ecr_image_registry");
        set => SetArgument("ecr_image_registry", value);
    }

    /// <summary>
    /// EcrImageRepositoryName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageRepositoryNameBlock>? EcrImageRepositoryName
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageRepositoryNameBlock>>("ecr_image_repository_name");
        set => SetArgument("ecr_image_repository_name", value);
    }

    /// <summary>
    /// EcrImageTags block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageTagsBlock>? EcrImageTags
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEcrImageTagsBlock>>("ecr_image_tags");
        set => SetArgument("ecr_image_tags", value);
    }

    /// <summary>
    /// EpssScore block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockEpssScoreBlock>? EpssScore
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockEpssScoreBlock>>("epss_score");
        set => SetArgument("epss_score", value);
    }

    /// <summary>
    /// ExploitAvailable block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockExploitAvailableBlock>? ExploitAvailable
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockExploitAvailableBlock>>("exploit_available");
        set => SetArgument("exploit_available", value);
    }

    /// <summary>
    /// FindingArn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingArnBlock>? FindingArn
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingArnBlock>>("finding_arn");
        set => SetArgument("finding_arn", value);
    }

    /// <summary>
    /// FindingStatus block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingStatusBlock>? FindingStatus
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingStatusBlock>>("finding_status");
        set => SetArgument("finding_status", value);
    }

    /// <summary>
    /// FindingType block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingTypeBlock>? FindingType
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockFindingTypeBlock>>("finding_type");
        set => SetArgument("finding_type", value);
    }

    /// <summary>
    /// FirstObservedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockFirstObservedAtBlock>? FirstObservedAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockFirstObservedAtBlock>>("first_observed_at");
        set => SetArgument("first_observed_at", value);
    }

    /// <summary>
    /// FixAvailable block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockFixAvailableBlock>? FixAvailable
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockFixAvailableBlock>>("fix_available");
        set => SetArgument("fix_available", value);
    }

    /// <summary>
    /// InspectorScore block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockInspectorScoreBlock>? InspectorScore
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockInspectorScoreBlock>>("inspector_score");
        set => SetArgument("inspector_score", value);
    }

    /// <summary>
    /// LambdaFunctionExecutionRoleArn block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionExecutionRoleArnBlock>? LambdaFunctionExecutionRoleArn
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionExecutionRoleArnBlock>>("lambda_function_execution_role_arn");
        set => SetArgument("lambda_function_execution_role_arn", value);
    }

    /// <summary>
    /// LambdaFunctionLastModifiedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLastModifiedAtBlock>? LambdaFunctionLastModifiedAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLastModifiedAtBlock>>("lambda_function_last_modified_at");
        set => SetArgument("lambda_function_last_modified_at", value);
    }

    /// <summary>
    /// LambdaFunctionLayers block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLayersBlock>? LambdaFunctionLayers
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLayersBlock>>("lambda_function_layers");
        set => SetArgument("lambda_function_layers", value);
    }

    /// <summary>
    /// LambdaFunctionName block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionNameBlock>? LambdaFunctionName
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionNameBlock>>("lambda_function_name");
        set => SetArgument("lambda_function_name", value);
    }

    /// <summary>
    /// LambdaFunctionRuntime block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionRuntimeBlock>? LambdaFunctionRuntime
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLambdaFunctionRuntimeBlock>>("lambda_function_runtime");
        set => SetArgument("lambda_function_runtime", value);
    }

    /// <summary>
    /// LastObservedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockLastObservedAtBlock>? LastObservedAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockLastObservedAtBlock>>("last_observed_at");
        set => SetArgument("last_observed_at", value);
    }

    /// <summary>
    /// NetworkProtocol block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockNetworkProtocolBlock>? NetworkProtocol
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockNetworkProtocolBlock>>("network_protocol");
        set => SetArgument("network_protocol", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

    /// <summary>
    /// RelatedVulnerabilities block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockRelatedVulnerabilitiesBlock>? RelatedVulnerabilities
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockRelatedVulnerabilitiesBlock>>("related_vulnerabilities");
        set => SetArgument("related_vulnerabilities", value);
    }

    /// <summary>
    /// ResourceId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceIdBlock>? ResourceId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceIdBlock>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// ResourceTags block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceTagsBlock>? ResourceTags
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceTagsBlock>>("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// ResourceTypeAttribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceTypeAttributeBlock>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockResourceTypeAttributeBlock>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// Severity block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockSeverityBlock>? Severity
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockSeverityBlock>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// Title block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockTitleBlock>? Title
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockTitleBlock>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// UpdatedAt block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockUpdatedAtBlock>? UpdatedAt
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockUpdatedAtBlock>>("updated_at");
        set => SetArgument("updated_at", value);
    }

    /// <summary>
    /// VendorSeverity block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockVendorSeverityBlock>? VendorSeverity
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockVendorSeverityBlock>>("vendor_severity");
        set => SetArgument("vendor_severity", value);
    }

    /// <summary>
    /// VulnerabilityId block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerabilityIdBlock>? VulnerabilityId
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerabilityIdBlock>>("vulnerability_id");
        set => SetArgument("vulnerability_id", value);
    }

    /// <summary>
    /// VulnerabilitySource block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerabilitySourceBlock>? VulnerabilitySource
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerabilitySourceBlock>>("vulnerability_source");
        set => SetArgument("vulnerability_source", value);
    }

    /// <summary>
    /// VulnerablePackages block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock>? VulnerablePackages
    {
        get => GetArgument<TerraformSet<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock>>("vulnerable_packages");
        set => SetArgument("vulnerable_packages", value);
    }

}

/// <summary>
/// Block type for aws_account_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockAwsAccountIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_account_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for code_repository_project_name in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProjectNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository_project_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for code_repository_provider_type in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockCodeRepositoryProviderTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository_provider_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for code_vulnerability_detector_name in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_vulnerability_detector_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for code_vulnerability_detector_tags in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityDetectorTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_vulnerability_detector_tags";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for code_vulnerability_file_path in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockCodeVulnerabilityFilePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_vulnerability_file_path";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for component_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockComponentIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for component_type in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockComponentTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ec2_instance_image_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEc2InstanceImageIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_instance_image_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ec2_instance_subnet_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEc2InstanceSubnetIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_instance_subnet_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ec2_instance_vpc_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEc2InstanceVpcIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_instance_vpc_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ecr_image_architecture in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageArchitectureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_architecture";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ecr_image_hash in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageHashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_hash";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ecr_image_in_use_count in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageInUseCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_in_use_count";

    /// <summary>
    /// The lower_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerInclusive is required")]
    public required TerraformValue<double> LowerInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_inclusive");
        set => SetArgument("lower_inclusive", value);
    }

    /// <summary>
    /// The upper_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperInclusive is required")]
    public required TerraformValue<double> UpperInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_inclusive");
        set => SetArgument("upper_inclusive", value);
    }

}

/// <summary>
/// Block type for ecr_image_last_in_use_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageLastInUseAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_last_in_use_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for ecr_image_pushed_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImagePushedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_pushed_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for ecr_image_registry in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_registry";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ecr_image_repository_name in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageRepositoryNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_repository_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ecr_image_tags in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEcrImageTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecr_image_tags";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for epss_score in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockEpssScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "epss_score";

    /// <summary>
    /// The lower_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerInclusive is required")]
    public required TerraformValue<double> LowerInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_inclusive");
        set => SetArgument("lower_inclusive", value);
    }

    /// <summary>
    /// The upper_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperInclusive is required")]
    public required TerraformValue<double> UpperInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_inclusive");
        set => SetArgument("upper_inclusive", value);
    }

}

/// <summary>
/// Block type for exploit_available in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockExploitAvailableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exploit_available";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_arn in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockFindingArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_status in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockFindingStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_status";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for finding_type in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockFindingTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "finding_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for first_observed_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockFirstObservedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "first_observed_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for fix_available in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockFixAvailableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fix_available";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for inspector_score in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockInspectorScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspector_score";

    /// <summary>
    /// The lower_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerInclusive is required")]
    public required TerraformValue<double> LowerInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_inclusive");
        set => SetArgument("lower_inclusive", value);
    }

    /// <summary>
    /// The upper_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperInclusive is required")]
    public required TerraformValue<double> UpperInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_inclusive");
        set => SetArgument("upper_inclusive", value);
    }

}

/// <summary>
/// Block type for lambda_function_execution_role_arn in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLambdaFunctionExecutionRoleArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_execution_role_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for lambda_function_last_modified_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLastModifiedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_last_modified_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for lambda_function_layers in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLambdaFunctionLayersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_layers";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for lambda_function_name in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLambdaFunctionNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for lambda_function_runtime in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLambdaFunctionRuntimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_runtime";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for last_observed_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockLastObservedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_observed_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for network_protocol in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockNetworkProtocolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_protocol";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for port_range in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The begin_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BeginInclusive is required")]
    public required TerraformValue<double> BeginInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("begin_inclusive");
        set => SetArgument("begin_inclusive", value);
    }

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndInclusive is required")]
    public required TerraformValue<double> EndInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

}

/// <summary>
/// Block type for related_vulnerabilities in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockRelatedVulnerabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "related_vulnerabilities";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockResourceIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_tags in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockResourceTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_tags";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_type in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockResourceTypeAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_type";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for severity in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockSeverityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "severity";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for title in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockTitleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "title";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for updated_at in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockUpdatedAtBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "updated_at";

    /// <summary>
    /// The end_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? EndInclusive
    {
        get => GetArgument<TerraformValue<string>>("end_inclusive");
        set => SetArgument("end_inclusive", value);
    }

    /// <summary>
    /// The start_inclusive attribute.
    /// </summary>
    public TerraformValue<string>? StartInclusive
    {
        get => GetArgument<TerraformValue<string>>("start_inclusive");
        set => SetArgument("start_inclusive", value);
    }

}

/// <summary>
/// Block type for vendor_severity in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVendorSeverityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vendor_severity";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for vulnerability_id in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerabilityIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vulnerability_id";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for vulnerability_source in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerabilitySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vulnerability_source";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for vulnerable_packages in AwsInspector2FilterFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vulnerable_packages";

    /// <summary>
    /// Architecture block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockArchitectureBlock>? Architecture
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockArchitectureBlock>>("architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// Epoch block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockEpochBlock>? Epoch
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockEpochBlock>>("epoch");
        set => SetArgument("epoch", value);
    }

    /// <summary>
    /// FilePath block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockFilePathBlock>? FilePath
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockFilePathBlock>>("file_path");
        set => SetArgument("file_path", value);
    }

    /// <summary>
    /// Name block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockNameBlock>? Name
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockNameBlock>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Release block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockReleaseBlock>? Release
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockReleaseBlock>>("release");
        set => SetArgument("release", value);
    }

    /// <summary>
    /// SourceLambdaLayerArn block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLambdaLayerArnBlock>? SourceLambdaLayerArn
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLambdaLayerArnBlock>>("source_lambda_layer_arn");
        set => SetArgument("source_lambda_layer_arn", value);
    }

    /// <summary>
    /// SourceLayerHash block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLayerHashBlock>? SourceLayerHash
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLayerHashBlock>>("source_layer_hash");
        set => SetArgument("source_layer_hash", value);
    }

    /// <summary>
    /// Version block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockVersionBlock>? Version
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockVersionBlock>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for architecture in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockArchitectureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "architecture";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for epoch in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockEpochBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "epoch";

    /// <summary>
    /// The lower_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerInclusive is required")]
    public required TerraformValue<double> LowerInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_inclusive");
        set => SetArgument("lower_inclusive", value);
    }

    /// <summary>
    /// The upper_inclusive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperInclusive is required")]
    public required TerraformValue<double> UpperInclusive
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_inclusive");
        set => SetArgument("upper_inclusive", value);
    }

}

/// <summary>
/// Block type for file_path in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockFilePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_path";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for name in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "name";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for release in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockReleaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "release";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_lambda_layer_arn in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLambdaLayerArnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_lambda_layer_arn";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_layer_hash in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockSourceLayerHashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_layer_hash";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for version in AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlock.
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlockVulnerablePackagesBlockVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "version";

    /// <summary>
    /// The comparison attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_inspector2_filter Terraform resource.
/// Manages a aws_inspector2_filter resource.
/// </summary>
public partial class AwsInspector2Filter(string name) : TerraformResource("aws_inspector2_filter", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    public TerraformValue<string>? Reason
    {
        get => GetArgument<TerraformValue<string>>("reason");
        set => SetArgument("reason", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// FilterCriteria block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsInspector2FilterFilterCriteriaBlock>? FilterCriteria
    {
        get => GetArgument<TerraformList<AwsInspector2FilterFilterCriteriaBlock>>("filter_criteria");
        set => SetArgument("filter_criteria", value);
    }

}
