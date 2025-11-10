using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRamResourceShareAccepterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

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
        SetOutput("invitation_arn");
        SetOutput("receiver_account_id");
        SetOutput("resources");
        SetOutput("sender_account_id");
        SetOutput("share_id");
        SetOutput("share_name");
        SetOutput("status");
        SetOutput("id");
        SetOutput("region");
        SetOutput("share_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareArn is required")]
    public required TerraformProperty<string> ShareArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("share_arn");
        set => SetProperty("share_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRamResourceShareAccepterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
