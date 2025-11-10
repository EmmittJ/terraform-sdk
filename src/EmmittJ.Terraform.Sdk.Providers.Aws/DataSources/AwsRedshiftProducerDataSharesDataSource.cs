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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProducerArn is required")]
    public required TerraformProperty<string> ProducerArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("producer_arn");
        set => this.WithProperty("producer_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
