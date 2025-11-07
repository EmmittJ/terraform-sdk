using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_workforce_pool_iam_binding resource.
/// </summary>
public class GoogleIamWorkforcePoolIamBinding : TerraformResource
{
    public GoogleIamWorkforcePoolIamBinding(string name) : base("google_iam_workforce_pool_iam_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The workforce_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkforcePoolId
    {
        get => GetProperty<TerraformProperty<string>>("workforce_pool_id");
        set => this.WithProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
