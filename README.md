# Lab C6 – Unity Animation & Sprite System

## Giới thiệu
Repository này chứa các bài lab thực hành về **Sprite, Animation và Animator trong Unity**.  
Mục tiêu là làm quen với quy trình:
# Lab 1 – Import Sprite & Basic Setup

Mục tiêu:  
Import sprite vào Unity và thiết lập các thông số cơ bản.

Các bước thực hiện:

- Import sprite vào thư mục `Assets/Sprites`
- Thiết lập:
  - Texture Type: `Sprite (2D and UI)`
  - Pixels Per Unit
  - Filter Mode
- Kiểm tra sprite hiển thị trong Scene.
Kết quả:
!<img width="975" height="519" alt="image" src="https://github.com/user-attachments/assets/4f2be17e-9d92-4978-a818-1f741d6bd1e6" />

---

# Lab 2 – Sprite Renderer & Scene Setup

Mục tiêu:  
Hiển thị sprite trong Scene và cấu hình Sprite Renderer.

Các bước:

- Tạo GameObject Player
- Add Component: `Sprite Renderer`
- Gán sprite vào renderer
- Điều chỉnh transform để hiển thị đúng vị trí.
Trả lời câu hỏi :
- PPU quyết định tỷ lệ kích thước sprite trong game world và giúp các sprite có tỉ lệ hiển thị đồng nhất.
Kết quả:
!<img width="975" height="516" alt="image" src="https://github.com/user-attachments/assets/62099f4c-3562-4af8-817b-22812f2d1103" />
!<img width="974" height="516" alt="image" src="https://github.com/user-attachments/assets/f1f81b66-901c-4e11-9655-eaf64c89b6ff" />

---

# Lab 3 – Sorting Layer

Mục tiêu:  
Hiểu cách Unity sắp xếp thứ tự hiển thị sprite.

Các bước:

- Tạo nhiều sprite trong scene
- Thiết lập `Sorting Layer`
- Điều chỉnh `Order in Layer` để thay đổi thứ tự hiển thị.

Kết quả:
!<img width="975" height="520" alt="image" src="https://github.com/user-attachments/assets/0a7237e1-0d70-467d-afad-b81cbf3ac1a2" />

---

# Lab 4 – Sprite Editor (Slice & Outline)

Mục tiêu:  
Sử dụng **Sprite Editor** để cắt sprite sheet và tối ưu mesh.

Các bước:

- Đặt Sprite Mode: `Multiple`
- Mở Sprite Editor
- Sử dụng:
  - Automatic slicing
  - Grid slicing
- Chỉnh sửa outline để tối ưu polygon.
Trả lời câu hỏi :
Edit Outline được dùng khi cần giảm phần mesh thừa, tối ưu hiệu năng và làm vùng bao sprite chính xác hơn.

Kết quả:
!<img width="975" height="519" alt="image" src="https://github.com/user-attachments/assets/6f4f47c5-051d-49b2-8093-72d690a3aa9d" />
!<img width="975" height="519" alt="image" src="https://github.com/user-attachments/assets/87626b08-b71e-4737-a79f-e46ce277b00f" />
---

# Lab 5 – Transparency Sort Mode

Mục tiêu:  
Hiểu cách Unity sắp xếp sprite theo camera.

Các chế độ thử nghiệm:

- Default
- Orthographic
- Perspective
- Custom Axis

So sánh kết quả:

### Custom Axis
!<img width="975" height="520" alt="image" src="https://github.com/user-attachments/assets/fddf501c-4664-486d-a5a9-af0dfe20f7c9" />
### Orthographic
!<img width="974" height="518" alt="image" src="https://github.com/user-attachments/assets/24b0063c-f626-459e-92d2-44dc557cc4ce" />

# Lab 6 – Animation Clip (Record vs Preview)

Mục tiêu:  
Tạo animation clip bằng Animation Window.

Các bước:

- Tạo GameObject Player
- Tạo Animation Clip
- Dùng Record Mode để tạo keyframes
- Thử chỉnh property trong Preview Mode.
Trả lời câu hỏi :
Record Mode → thay đổi sẽ tự ghi keyframe.
Preview Mode → chỉ xem thử, không ghi keyframe tự động.
Demo:
https://github.com/user-attachments/assets/8be92fee-0e01-4333-8b72-f36141e6c8da

---

# Lab 7 – Animator Controller

Mục tiêu:  
Tạo **State Machine Animation**.

Các animation:

- Idle
- Run
- Attack
Demo:

https://github.com/user-attachments/assets/0c9d2c3d-eb00-48f8-8499-1ed591d6fda4

---
https://github.com/user-attachments/assets/0c9d2c3d-eb00-48f8-8499-1ed591d6fda4

# Mini Project 

Quy trình bắt đầu bằng việc import sprite hoặc sprite sheet vào Unity và thiết lập Texture Type = Sprite (2D and UI). Nếu là sprite sheet, sử dụng Sprite Editor để cắt (slice) thành nhiều frame sprite riêng lẻ.

Sau đó, các sprite này được sử dụng để tạo Animation Clip trong Animation Window. Bằng cách sử dụng Record Mode, các frame sprite được sắp xếp theo timeline để tạo chuyển động như Idle, Run hoặc Attack.

Tiếp theo, các animation clip được đưa vào Animator Controller để xây dựng state machine. Trong Animator, các state như Idle, Run và Attack được kết nối bằng transition và điều khiển bằng parameters (ví dụ: Speed, Attack).

Cuối cùng, một script C# được dùng để đọc input từ người chơi và gọi Animator API (như SetFloat, SetTrigger) để thay đổi trạng thái animation trong game.

Workflow tổng thể:

Sprite Import → Sprite Slice → Animation Clip → Animator Controller → Script Control

