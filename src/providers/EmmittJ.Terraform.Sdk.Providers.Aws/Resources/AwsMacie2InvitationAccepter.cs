using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2InvitationAccepterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_macie2_invitation_accepter resource.
/// </summary>
public class AwsMacie2InvitationAccepter : TerraformResource
{
    public AwsMacie2InvitationAccepter(string name) : base("aws_macie2_invitation_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("invitation_id");
        SetOutput("administrator_account_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministratorAccountId is required")]
    public required TerraformProperty<string> AdministratorAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_account_id");
        set => SetProperty("administrator_account_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMacie2InvitationAccepterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The invitation_id attribute.
    /// </summary>
    public TerraformExpression InvitationId => this["invitation_id"];

}
