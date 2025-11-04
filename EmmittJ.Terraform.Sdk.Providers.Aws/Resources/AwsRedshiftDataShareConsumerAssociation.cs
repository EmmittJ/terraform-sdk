using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_consumer_association resource.
/// </summary>
public class AwsRedshiftDataShareConsumerAssociation : TerraformResource
{
    public AwsRedshiftDataShareConsumerAssociation(string name) : base("aws_redshift_data_share_consumer_association", name)
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
    /// The associate_entire_account attribute.
    /// </summary>
    public bool? AssociateEntireAccount
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_entire_account")?.Value;
        set => this.WithProperty("associate_entire_account", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public string? ConsumerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_arn")?.Value;
        set => this.WithProperty("consumer_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The consumer_region attribute.
    /// </summary>
    public string? ConsumerRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_region")?.Value;
        set => this.WithProperty("consumer_region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
