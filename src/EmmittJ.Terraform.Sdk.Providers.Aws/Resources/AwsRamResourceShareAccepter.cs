using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ram_resource_share_accepter resource.
/// </summary>
public class AwsRamResourceShareAccepter : TerraformResource
{
    public AwsRamResourceShareAccepter(string name) : base("aws_ram_resource_share_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("invitation_arn");
        this.DeclareOutput("receiver_account_id");
        this.DeclareOutput("resources");
        this.DeclareOutput("sender_account_id");
        this.DeclareOutput("share_id");
        this.DeclareOutput("share_name");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The share_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ShareArn
    {
        get => GetProperty<TerraformProperty<string>>("share_arn");
        set => this.WithProperty("share_arn", value);
    }

    /// <summary>
    /// The invitation_arn attribute.
    /// </summary>
    public TerraformExpression InvitationArn => this["invitation_arn"];

    /// <summary>
    /// The receiver_account_id attribute.
    /// </summary>
    public TerraformExpression ReceiverAccountId => this["receiver_account_id"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

    /// <summary>
    /// The sender_account_id attribute.
    /// </summary>
    public TerraformExpression SenderAccountId => this["sender_account_id"];

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public TerraformExpression ShareId => this["share_id"];

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    public TerraformExpression ShareName => this["share_name"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
