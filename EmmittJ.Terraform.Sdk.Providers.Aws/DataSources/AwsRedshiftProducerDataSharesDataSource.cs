using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_producer_data_shares.
/// </summary>
public class AwsRedshiftProducerDataSharesDataSource : TerraformDataSource
{
    public AwsRedshiftProducerDataSharesDataSource(string name) : base("aws_redshift_producer_data_shares", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    public string? ProducerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("producer_arn")?.Value;
        set => this.WithProperty("producer_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
