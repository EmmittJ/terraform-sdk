using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("invitation_id");
    }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    public string? AdministratorAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_account_id")?.Value;
        set => this.WithProperty("administrator_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The invitation_id attribute.
    /// </summary>
    public TerraformExpression InvitationId => this["invitation_id"];

}
