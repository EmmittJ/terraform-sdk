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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The share_arn attribute.
    /// </summary>
    public string? ShareArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_arn")?.Value;
        set => this.WithProperty("share_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
