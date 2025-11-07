using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_hl7_v2_store_iam_member resource.
/// </summary>
public class GoogleHealthcareHl7V2StoreIamMember : TerraformResource
{
    public GoogleHealthcareHl7V2StoreIamMember(string name) : base("google_healthcare_hl7_v2_store_iam_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    public TerraformProperty<string>? Hl7V2StoreId
    {
        get => GetProperty<TerraformProperty<string>>("hl7_v2_store_id");
        set => this.WithProperty("hl7_v2_store_id", value);
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
    /// The member attribute.
    /// </summary>
    public TerraformProperty<string>? Member
    {
        get => GetProperty<TerraformProperty<string>>("member");
        set => this.WithProperty("member", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
