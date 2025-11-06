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
        this.DeclareOutput("data_shares");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The data_shares attribute.
    /// </summary>
    public TerraformExpression DataShares => this["data_shares"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
