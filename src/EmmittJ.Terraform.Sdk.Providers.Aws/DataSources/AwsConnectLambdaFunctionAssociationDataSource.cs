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
    public TerraformLiteralProperty<string>? FunctionArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_arn");
        set => this.WithProperty("function_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
