using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_authorization resource.
/// </summary>
public class AwsRedshiftDataShareAuthorization : TerraformResource
{
    public AwsRedshiftDataShareAuthorization(string name) : base("aws_redshift_data_share_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("managed_by");
        this.DeclareOutput("producer_arn");
    }

    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    public bool? AllowWrites
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_writes")?.Value;
        set => this.WithProperty("allow_writes", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The consumer_identifier attribute.
    /// </summary>
    public string? ConsumerIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_identifier")?.Value;
        set => this.WithProperty("consumer_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    public string? DataShareArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_share_arn")?.Value;
        set => this.WithProperty("data_share_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The managed_by attribute.
    /// </summary>
    public TerraformExpression ManagedBy => this["managed_by"];

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    public TerraformExpression ProducerArn => this["producer_arn"];

}
