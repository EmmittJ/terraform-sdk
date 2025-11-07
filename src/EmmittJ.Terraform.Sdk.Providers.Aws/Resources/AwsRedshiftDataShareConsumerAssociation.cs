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
    public TerraformLiteralProperty<bool>? AllowWrites
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_writes");
        set => this.WithProperty("allow_writes", value);
    }

    /// <summary>
    /// The associate_entire_account attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AssociateEntireAccount
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_entire_account");
        set => this.WithProperty("associate_entire_account", value);
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConsumerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_arn");
        set => this.WithProperty("consumer_arn", value);
    }

    /// <summary>
    /// The consumer_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConsumerRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_region");
        set => this.WithProperty("consumer_region", value);
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataShareArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_share_arn");
        set => this.WithProperty("data_share_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
