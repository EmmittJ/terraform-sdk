using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsS3controlObjectLambdaAccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsS3controlObjectLambdaAccessPointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The allowed_features attribute.
    /// </summary>
    public TerraformSet<string>? AllowedFeatures
    {
        get => GetArgument<TerraformSet<string>>("allowed_features");
        set => SetArgument("allowed_features", value);
    }

    /// <summary>
    /// The cloud_watch_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CloudWatchMetricsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cloud_watch_metrics_enabled");
        set => SetArgument("cloud_watch_metrics_enabled", value);
    }

    /// <summary>
    /// The supporting_access_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportingAccessPoint is required")]
    public required TerraformValue<string> SupportingAccessPoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("supporting_access_point");
        set => SetArgument("supporting_access_point", value);
    }

    /// <summary>
    /// TransformationConfiguration block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TransformationConfiguration block(s) required")]
    public required TerraformSet<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlock> TransformationConfiguration
    {
        get => GetRequiredArgument<TerraformSet<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlock>>("transformation_configuration");
        set => SetArgument("transformation_configuration", value);
    }

}

/// <summary>
/// Block type for transformation_configuration in AwsS3controlObjectLambdaAccessPointConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_configuration";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => GetRequiredArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// ContentTransformation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTransformation block(s) allowed")]
    public required TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlock> ContentTransformation
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlock>>("content_transformation");
        set => SetArgument("content_transformation", value);
    }

}

/// <summary>
/// Block type for content_transformation in AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_transformation";

    /// <summary>
    /// AwsLambda block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsLambda is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AwsLambda block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLambda block(s) allowed")]
    public required TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlockAwsLambdaBlock> AwsLambda
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlockAwsLambdaBlock>>("aws_lambda");
        set => SetArgument("aws_lambda", value);
    }

}

/// <summary>
/// Block type for aws_lambda in AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlObjectLambdaAccessPointConfigurationBlockTransformationConfigurationBlockContentTransformationBlockAwsLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_lambda";

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_arn");
        set => SetArgument("function_arn", value);
    }

    /// <summary>
    /// The function_payload attribute.
    /// </summary>
    public TerraformValue<string>? FunctionPayload
    {
        get => GetArgument<TerraformValue<string>>("function_payload");
        set => SetArgument("function_payload", value);
    }

}


/// <summary>
/// Represents a aws_s3control_object_lambda_access_point Terraform resource.
/// Manages a aws_s3control_object_lambda_access_point resource.
/// </summary>
public partial class AwsS3controlObjectLambdaAccessPoint(string name) : TerraformResource("aws_s3control_object_lambda_access_point", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? AsReference("account_id");
        set => SetArgument("account_id", value);
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
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => AsReference("alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public required TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlock> Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlObjectLambdaAccessPointConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
