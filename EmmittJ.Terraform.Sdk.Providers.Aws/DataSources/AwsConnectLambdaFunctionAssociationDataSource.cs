using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_lambda_function_association.
/// </summary>
public class AwsConnectLambdaFunctionAssociationDataSource : TerraformDataSource
{
    public AwsConnectLambdaFunctionAssociationDataSource(string name) : base("aws_connect_lambda_function_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public string? FunctionArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_arn")?.Value;
        set => this.WithProperty("function_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
